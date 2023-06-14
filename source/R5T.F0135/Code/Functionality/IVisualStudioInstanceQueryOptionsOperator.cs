using System;
using System.IO;

using Microsoft.Build.Locator;

using R5T.T0132;


namespace R5T.F0135
{
    [FunctionalityMarker]
    public partial interface IVisualStudioInstanceQueryOptionsOperator : IFunctionalityMarker
    {
        public string Describe_To_String(VisualStudioInstanceQueryOptions options)
        {
            var lines = Instances.EnumerableOperator.From(
                $"Working directory:\n\t{options.WorkingDirectory}",
                $"{options.DiscoveryTypes}: Discovery types"
            );

            var text = Instances.TextOperator.JoinLines(lines);
            return text;
        }

        public void Describe_To(
            VisualStudioInstanceQueryOptions options,
            TextWriter writer)
        {
            var text = this.Describe_To_String(options);

            writer.WriteLine(text);
        }

        public VisualStudioInstanceQueryOptions Get_All()
        {
            // Start with default to get the working directory.
            var options = this.Get_Default();

            options.DiscoveryTypes = DiscoveryType.DeveloperConsole | DiscoveryType.DotNetSdk | DiscoveryType.VisualStudioSetup;

            return options;
        }

        public VisualStudioInstanceQueryOptions Get_Default()
        {
            var output = VisualStudioInstanceQueryOptions.Default;
            return output;
        }
    }
}
