﻿namespace TeamBuildScreen.Tfs2010.Models
{
    using System.ComponentModel.Composition;

    using TeamBuildScreen.Core.Models;

    [Export(typeof(IServerManifest))]
    public class Tfs2010Manifest : ServerManifest<BuildServerService, TeamProjectPickerAdapter> { }
}