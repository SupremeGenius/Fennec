using System.Collections.Generic;
using Fennec.View;

namespace Fennec.Model
{
    class Model
    {
        private List<IView> views = new List<IView>();

        public void AddView(IView view)
        {
            this.views.Add(view);
        }

        public void Changed()
        {
            foreach (IView v in views)
                v.ModelChanged();
        }
    }
}
