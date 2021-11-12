using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Tuan2
{
    public class FlyoutPageLearningFlyoutMenuItem
    {
        public FlyoutPageLearningFlyoutMenuItem()
        {
            TargetType = typeof(FlyoutPageLearningFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
        public string IconSource { get; set; }
    }
}