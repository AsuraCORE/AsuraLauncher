// Copyright (c) Burralis.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Burralis.Game.Launcher.Structures;

struct ProcessInformation
{
    public nint ProcessHandle;
    public nint ThreadHandle;
    public uint ProcessId;
    public uint ThreadId;

    public static int Size => Marshal.SizeOf<ProcessInformation>();
}
