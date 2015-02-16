using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pequam.Web.Models
{
    interface IActivityRepository
    {
        List<Activity> FetchByLoginName(string loginName);
        void AddActivity(Activity activity);
    }
}
