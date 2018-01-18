#region License, Terms and Author(s)
//
// NotWebMatrix
// Copyright (c) 2012 Atif Aziz. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

namespace NotWebMatrix.Data
{
    using System;
    using System.Data.Common;

    /// <summary>
    /// Provides data for the <see cref="Database.ConnectionOpened"/> event
    /// of the <see cref="Database"/> class.
    /// </summary>

    public class ConnectionEventArgs : EventArgs
    {
        public DbConnection Connection { get; private set; }

        public ConnectionEventArgs(DbConnection connection)
        {
            Connection = connection;
        }
    }
}
