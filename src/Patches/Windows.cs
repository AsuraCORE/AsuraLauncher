// Copyright (c) Burralis.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Burralis.Game.Launcher.Patches;

static class Windows
{
    // Registry entry used for -launcherlogin.
    public static byte[] LauncherLogin = Encoding.UTF8.GetBytes(@"Software\Custom Game Server Dev\Battle.net\Launch Options\");
}
