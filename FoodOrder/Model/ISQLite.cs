﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace FoodOrder.Model
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
