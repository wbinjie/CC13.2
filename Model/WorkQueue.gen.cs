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
    public partial class WorkQueue: ServerEntity
    {
        #region Constructors
        public WorkQueue():base("WorkQueue")
        {}
        public WorkQueue(
             ServerEntityKey _serverPartitionKey_
            ,ServerEntityKey _studyStorageKey_
            ,WorkQueueTypeEnum _workQueueTypeEnum_
            ,WorkQueueStatusEnum _workQueueStatusEnum_
            ,WorkQueuePriorityEnum _workQueuePriorityEnum_
            ,Int32 _failureCount_
            ,DateTime _scheduledTime_
            ,DateTime _insertTime_
            ,DateTime? _lastUpdatedTime_
            ,String _failureDescription_
            ,XmlDocument _data_
            ,ServerEntityKey _externalRequestQueueKey_
            ,String _processorID_
            ,String _groupID_
            ,DateTime? _expirationTime_
            ,ServerEntityKey _deviceKey_
            ,ServerEntityKey _studyHistoryKey_
            ):base("WorkQueue")
        {
            ServerPartitionKey = _serverPartitionKey_;
            StudyStorageKey = _studyStorageKey_;
            WorkQueueTypeEnum = _workQueueTypeEnum_;
            WorkQueueStatusEnum = _workQueueStatusEnum_;
            WorkQueuePriorityEnum = _workQueuePriorityEnum_;
            FailureCount = _failureCount_;
            ScheduledTime = _scheduledTime_;
            InsertTime = _insertTime_;
            LastUpdatedTime = _lastUpdatedTime_;
            FailureDescription = _failureDescription_;
            Data = _data_;
            ExternalRequestQueueKey = _externalRequestQueueKey_;
            ProcessorID = _processorID_;
            GroupID = _groupID_;
            ExpirationTime = _expirationTime_;
            DeviceKey = _deviceKey_;
            StudyHistoryKey = _studyHistoryKey_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="ServerPartitionGUID")]
        public ServerEntityKey ServerPartitionKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="StudyStorageGUID")]
        public ServerEntityKey StudyStorageKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="WorkQueueTypeEnum")]
        public WorkQueueTypeEnum WorkQueueTypeEnum
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="WorkQueueStatusEnum")]
        public WorkQueueStatusEnum WorkQueueStatusEnum
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="WorkQueuePriorityEnum")]
        public WorkQueuePriorityEnum WorkQueuePriorityEnum
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="FailureCount")]
        public Int32 FailureCount
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="ScheduledTime")]
        public DateTime ScheduledTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="InsertTime")]
        public DateTime InsertTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="LastUpdatedTime")]
        public DateTime? LastUpdatedTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="FailureDescription")]
        public String FailureDescription
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="Data")]
        public XmlDocument Data
        { get { return _Data; } set { _Data = value; } }
        [NonSerialized]
        private XmlDocument _Data;
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="ExternalRequestQueueGUID")]
        public ServerEntityKey ExternalRequestQueueKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="ProcessorID")]
        public String ProcessorID
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="GroupID")]
        public String GroupID
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="ExpirationTime")]
        public DateTime? ExpirationTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="DeviceGUID")]
        public ServerEntityKey DeviceKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="StudyHistoryGUID")]
        public ServerEntityKey StudyHistoryKey
        { get; set; }
        #endregion

        #region Static Methods
        static public WorkQueue Load(ServerEntityKey key)
        {
            using (var context = new ServerExecutionContext())
            {
                return Load(context.ReadContext, key);
            }
        }
        static public WorkQueue Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IWorkQueueEntityBroker>();
            WorkQueue theObject = broker.Load(key);
            return theObject;
        }
        static public WorkQueue Insert(WorkQueue entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                WorkQueue newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public WorkQueue Insert(IUpdateContext update, WorkQueue entity)
        {
            var broker = update.GetBroker<IWorkQueueEntityBroker>();
            var updateColumns = new WorkQueueUpdateColumns();
            updateColumns.ServerPartitionKey = entity.ServerPartitionKey;
            updateColumns.StudyStorageKey = entity.StudyStorageKey;
            updateColumns.WorkQueueTypeEnum = entity.WorkQueueTypeEnum;
            updateColumns.WorkQueueStatusEnum = entity.WorkQueueStatusEnum;
            updateColumns.WorkQueuePriorityEnum = entity.WorkQueuePriorityEnum;
            updateColumns.FailureCount = entity.FailureCount;
            updateColumns.ScheduledTime = entity.ScheduledTime;
            updateColumns.InsertTime = entity.InsertTime;
            updateColumns.LastUpdatedTime = entity.LastUpdatedTime;
            updateColumns.FailureDescription = entity.FailureDescription;
            updateColumns.Data = entity.Data;
            updateColumns.ExternalRequestQueueKey = entity.ExternalRequestQueueKey;
            updateColumns.ProcessorID = entity.ProcessorID;
            updateColumns.GroupID = entity.GroupID;
            updateColumns.ExpirationTime = entity.ExpirationTime;
            updateColumns.DeviceKey = entity.DeviceKey;
            updateColumns.StudyHistoryKey = entity.StudyHistoryKey;
            WorkQueue newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
