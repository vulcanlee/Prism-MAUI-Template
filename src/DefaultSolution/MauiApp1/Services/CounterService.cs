﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services;

public class CounterService
{
    public string Get(int id) => $"訊息內容 : {id}";
}
