using System;
using System.Collections.Generic;
using Jellyfin.Plugin.LrcLib.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.LrcLib;

/// <summary>
/// LrcLib plugin.
/// </summary>
public class LrcLibPlugin : BasePlugin<PluginConfiguration>, IHasWebPages
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LrcLibPlugin"/> class.
    /// </summary>
    /// <param name="applicationPaths">Instance of the <see cref="IApplicationPaths"/>.</param>
    /// <param name="xmlSerializer">Instance of the <see cref="IXmlSerializer"/>.</param>
    public LrcLibPlugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
        : base(applicationPaths, xmlSerializer)
    {
        Instance = this;
    }

    /// <inheritdoc />
    public override string Name => "LrcLib";

    /// <inheritdoc />
    public override Guid Id => Guid.Parse("D106EBE6-9CA8-4FBC-9CD1-A92A213DA9F9");

    /// <summary>
    /// Gets the current plugin instance.
    /// </summary>
    public static LrcLibPlugin? Instance { get; private set; }

    /// <inheritdoc />
    public IEnumerable<PluginPageInfo> GetPages()
    {
        yield return new PluginPageInfo
        {
            Name = Name,
            EmbeddedResourcePath = $"{GetType().Namespace}.Configuration.config.html"
        };
    }
}