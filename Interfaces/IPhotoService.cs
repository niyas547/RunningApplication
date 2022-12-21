using CloudinaryDotNet.Actions;

namespace RunningApplication.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
        
        Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}
