using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace PythonIntegrationSample
{
    /*
     * In a larger context, I would more likely make something more generic/re-usable, but for something this small
     * it is just extra work for no benefit.
     */
    class PythonHandler
    {
        private ScriptEngine engine;
        private ScriptScope scope;
        public dynamic Permutation;
        public dynamic Combination;

        public PythonHandler()
        {
            this.engine = Python.CreateEngine();
            this.scope = engine.CreateScope();
            this.engine.ExecuteFile(@"combinatorics.py", scope);
            this.Permutation = scope.GetVariable("Permutation");
            this.Combination = scope.GetVariable("Combination");
        }
    }
}
