namespace sa1100debug
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class BaseClass<T, V>
    {
        protected int Mode { get; set; }

        public virtual string GetFirstLastName()
        {
            return "firstLastName";
        }

        protected string GetNotOverridableName()
        {
            return "notOverridable";
        }
    }
}
