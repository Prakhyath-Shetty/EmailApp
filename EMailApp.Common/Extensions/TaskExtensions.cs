using System.Threading.Tasks;

namespace EMailApp.Common.Extensions
{
    public static class TaskExtensions
    {
        public static async void Forget(this Task task)
        {
            await task.ConfigureAwait(false);
        }
    }
}
