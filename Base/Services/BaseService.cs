using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Solus.Microservice.Base.Services
{
    public abstract class BaseService<T> where T : class
    {
        protected readonly ILogger _logger;

        protected BaseService(ILogger logger)
        {
            _logger = logger;
        }

        protected async Task<TResult> ExecuteSafeAsync<TResult>(Func<Task<TResult>> action, string actionName = null)
        {
            try
            {
                var sw = Stopwatch.StartNew();
                TResult result = await action();
                sw.Stop();
                _logger.LogInformation($"{typeof(T).Name} - {actionName ?? "action"} completed in {sw.ElapsedMilliseconds}ms");
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{typeof(T).Name} - Error in {actionName ?? "action"}");
                throw;
            }
        }
    }
}