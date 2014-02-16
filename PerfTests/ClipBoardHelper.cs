﻿using System.Threading;
using System.Windows.Forms;

static class ClipBoardHelper
{
    public static void SetClipboard(string result)
    {
        var thread = new Thread(() => Clipboard.SetText(result));
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        thread.Join();
    }
}