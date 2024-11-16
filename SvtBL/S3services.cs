using Amazon;
using Amazon.S3;
using Amazon.Runtime;
using Amazon.S3.Transfer;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;


namespace SvtBL
{
    public class S3Services
    {
         IAmazonS3 _s3Client;
         string _bucketName;

        public S3Services(IConfiguration configuration)
        {
            
            var accessKey = configuration["AWS:AccessKey"];
            var secretKey = configuration["AWS:SecretKey"];
            var region = configuration["AWS:Region"];

            
            var credentials = new Amazon.Runtime.BasicAWSCredentials(accessKey, secretKey);

            
            _s3Client = new AmazonS3Client(credentials, RegionEndpoint.GetBySystemName(region));

            
            _bucketName = configuration["AWS:BucketName"];
        }

        
        public async Task<string> UploadFileAsync(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentException("File cannot be null or empty");
            }

            
            using var newMemoryStream = new MemoryStream();
            await file.CopyToAsync(newMemoryStream); 

            
            var uploadRequest = new TransferUtilityUploadRequest
            {
                InputStream = newMemoryStream, 
                Key = file.FileName,           
                BucketName = _bucketName,     
                ContentType = file.ContentType 
            };

            // Use TransferUtility to upload the file to S3
            var fileTransferUtility = new TransferUtility(_s3Client);
            await fileTransferUtility.UploadAsync(uploadRequest);

            // Return a success message with the file name and bucket name
            return $"File '{file.FileName}' uploaded successfully to bucket '{_bucketName}'.";
        }
    }
}
