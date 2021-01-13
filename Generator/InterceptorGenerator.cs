using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Interception
{
    [Generator]
    public class InterceptorGenerator : ISourceGenerator
    {
        private const string INTERCEPTOR_MARKER = "GenerateInterceptor";

        public void Execute(GeneratorExecutionContext context)
        {
				var sb = new StringBuilder();
                sb.AppendLine("namespace Foo{ class Foo{}}");
                context.AddSource(new Guid().ToString("N")+".cs", sb.ToString());
        }

        public void Initialize(GeneratorInitializationContext context)
        {
        }
    }
}