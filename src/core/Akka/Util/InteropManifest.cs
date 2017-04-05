using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akka.Util
{
  /// <summary>
  /// Attribute is used for the Akka.Net Serilization Engine to manifest the java class name on messages sent to Akka.
  /// </summary>
  public class InteropManifest : Attribute
  {
    // ReSharper disable once MemberCanBePrivate.Global
    // ReSharper disable once InconsistentNaming
    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public string Name { get; set; }
    public InteropManifest(string interopManifestString)
    {
      Name = interopManifestString;
    }
  }
}
