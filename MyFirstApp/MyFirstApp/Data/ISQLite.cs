﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstApp.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
