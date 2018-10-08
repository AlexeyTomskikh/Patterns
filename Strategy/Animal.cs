using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Animal
    {
        public IRunBehavior runBehavior;
        public IFlyBehavior flyBeahavior;
        public void PerformRun()
        {
            runBehavior.Run();
        }
        public void Performfly()
        {
            flyBeahavior.Fly();
        }
    }
}
