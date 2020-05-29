using System.Threading.Tasks;

namespace Tutorials.UmbracoDI.Core.Services
{
    public interface ICommunicationService
    {
        Task SendCommentToHost(string name, string email, string comment);
    }
}