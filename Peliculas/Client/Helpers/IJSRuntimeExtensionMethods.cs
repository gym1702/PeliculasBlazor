﻿using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Peliculas.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string mensaje)
        {
            return await js.InvokeAsync<bool>("confirm", mensaje);
        }
    }
}
