// Copyright (c) Burralis.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Burralis.Game.Launcher.Patterns;

static class Windows
{
    // Registry entry used for -launcherlogin.
    public static short[] LauncherLogin = @"Software\Blizzard Entertainment\Battle.net\Launch Options\".ToPattern();
}
