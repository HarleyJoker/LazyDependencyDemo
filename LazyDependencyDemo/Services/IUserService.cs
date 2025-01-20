using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyDependencyDemo.Services
{
    public interface IUserService
    {
        void GetUserAndNotify(int userId);
    }
}
