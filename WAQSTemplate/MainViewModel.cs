using $safeprojectname$;
using $safeprojectname$.ClientContext;
using $safeprojectname$.ClientContext.Interfaces;
using $safeprojectname$.ClientContext.Interfaces.Errors;
using WCFAsyncQueryableServices.ClientContext;
using WCFAsyncQueryableServices.ClientContext.Interfaces;
using WCFAsyncQueryableServices.ClientContext.Interfaces.Errors;
using WCFAsyncQueryableServices.ClientContext.Interfaces.Querying;
using WCFAsyncQueryableServices.ComponentModel;

namespace $safeprojectname$
{
    class MainViewModel : ViewModelBase
    {
        private IWAQSModelClientContext _context;
        public MainVM(IWAQSModelClientContext context): base (context)
        {
            _context = context;
            //Call async worker function here
            //FooAsync().ConfigureAwait(true);
        }
        
        //Sample worker function for interaction with database
        //private async Task FooAsync()
        //{
            //Call queries here
            //var test = await _context.Entity1.AsAsyncQueryable().Where(e => e.NameLength > 5).ExecuteAsync();
            //var test2 = await _context.Entity1.AsAsyncQueryable().ExecuteAsync();

            //Edit table entries here
            //test.First().Name += "!";

            //Add new entries here
            //var test3 = new Entity1() {Name = "Sam", Size = "5"};
            //_context.Entity1.Add(test3);

            //Erase entries from table here
            //_context.Entity1.Remove(test2.Last());
            
            //Remember to save changes before exitiing
            //await _context.SaveChangesAsync();
        //}
    }
}
