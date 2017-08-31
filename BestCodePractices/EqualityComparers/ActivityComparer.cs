using BestCodePractices.Models;
using System.Collections.Generic;

namespace BestCodePractices.EqualityComparers
{
    /// <summary>
    /// ActivityComparer : comparing by identifier
    /// </summary>
    /// <seealso cref="System.Collections.Generic.IEqualityComparer{BestCodePractices.Models.Activity}" />
    public class ActivityComparer : IEqualityComparer<Activity>
    {
        public bool Equals(Activity x, Activity y)
        {
            if (x.ActivityId == y.ActivityId)
                return true;
            return false;
        }

        public int GetHashCode(Activity obj)
        {
            return obj.ActivityId.GetHashCode();
        }
    }

    /// <summary>
    /// ActivityComparer: comapring multiple parameters
    /// </summary>
    /// <seealso cref="System.Collections.Generic.IEqualityComparer{BestCodePractices.Models.Activity}" />
    public class MultiValueActivityComparer : IEqualityComparer<Activity>
    {
        public bool Equals(Activity x, Activity y)
        {
            if (x.ActivityId == y.ActivityId)
                return true;
            if (x.OwnerId == y.OwnerId)
                return true;
            return false;
        }

        public int GetHashCode(Activity obj)
        {
            return obj.ActivityId.GetHashCode();
        }
    }
}