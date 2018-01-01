#region License

// Copyright (c) 2013, MatrixPACS Inc.
// All rights reserved.
// http://www.MatrixPACS.ca
//
// This file is part of the MatrixPACS RIS/PACS open source project.
//
// The MatrixPACS RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The MatrixPACS RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the MatrixPACS RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the MatrixPACS.Model.SqlServer.CodeGenerator project.

namespace MatrixPACS.ImageServer.Model
{
    using System;
    using System.Xml;
    using MatrixPACS.Enterprise.Core;
    using MatrixPACS.ImageServer.Enterprise;
    using MatrixPACS.ImageServer.Enterprise.Command;
    using MatrixPACS.ImageServer.Model.EntityBrokers;

    [Serializable]
    public partial class ApplicationLog: ServerEntity
    {
        #region Constructors
        public ApplicationLog():base("ApplicationLog")
        {}
        public ApplicationLog(
             String _host_
            ,DateTime _timestamp_
            ,String _logLevel_
            ,String _thread_
            ,String _message_
            ,String _exception_
            ):base("ApplicationLog")
        {
            Host = _host_;
            Timestamp = _timestamp_;
            LogLevel = _logLevel_;
            Thread = _thread_;
            Message = _message_;
            Exception = _exception_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="ApplicationLog", ColumnName="Host")]
        public String Host
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ApplicationLog", ColumnName="Timestamp")]
        public DateTime Timestamp
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ApplicationLog", ColumnName="LogLevel")]
        public String LogLevel
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ApplicationLog", ColumnName="Thread")]
        public String Thread
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ApplicationLog", ColumnName="Message")]
        public String Message
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ApplicationLog", ColumnName="Exception")]
        public String Exception
        { get; set; }
        #endregion

        #region Static Methods
        static public ApplicationLog Load(ServerEntityKey key)
        {
            using (var context = new ServerExecutionContext())
            {
                return Load(context.ReadContext, key);
            }
        }
        static public ApplicationLog Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IApplicationLogEntityBroker>();
            ApplicationLog theObject = broker.Load(key);
            return theObject;
        }
        static public ApplicationLog Insert(ApplicationLog entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                ApplicationLog newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public ApplicationLog Insert(IUpdateContext update, ApplicationLog entity)
        {
            var broker = update.GetBroker<IApplicationLogEntityBroker>();
            var updateColumns = new ApplicationLogUpdateColumns();
            updateColumns.Host = entity.Host;
            updateColumns.Timestamp = entity.Timestamp;
            updateColumns.LogLevel = entity.LogLevel;
            updateColumns.Thread = entity.Thread;
            updateColumns.Message = entity.Message;
            updateColumns.Exception = entity.Exception;
            ApplicationLog newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}