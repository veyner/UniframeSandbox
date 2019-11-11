using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniframeSandbox.EntityObjects;
using UniframeSandbox.ViewObjects;

namespace UniframeSandbox
{
    public class ConverterEntityToView
    {
        public ViewFacility ConvertFacility(EntityFacility entityFacility, EntityCoordinates entityCoordinates)
        {
            var viewFacility = new ViewFacility()
            {
                FacilityId = entityFacility.FacilityId,
                Description = entityFacility.Description,
                Name = entityFacility.Name,
                FacilityCoordinates = new ViewFacilityCoordinates()
                {
                    Lat = entityCoordinates.Lat,
                    Long = entityCoordinates.Long
                }
                
            };
            return viewFacility;
        }

        public ViewState ConvertState(EntityFacilityState entityFacilityState)
        {
            var viewState = new ViewState()
            {
                FacilityID = entityFacilityState.FacilityID,
                Alarm = ConvertStateAlarm(entityFacilityState.Alarm),
                Common = ConvertStateCommon(entityFacilityState.Common),
                Connection = ConvertStateConnection(entityFacilityState.Connection),
                Device = ConvertStateDevice(entityFacilityState.Device),
                System = ConvertStateSystem(entityFacilityState.System),
                Parameters = entityFacilityState.Parameters.Select(x => ConvertParameter(x)).ToList()
            };
            return viewState;
        }

        public ViewStateCommon ConvertStateCommon(EntityStateCommon entityStateCommon)
        {
            var viewCommon = new ViewStateCommon()
            {
                Current = entityStateCommon.Current.ToString(),
                Name = entityStateCommon.Name,
                Note = entityStateCommon.Note,
                StateAtDate = entityStateCommon.StateAtDate.ToString("O")
            };
            return viewCommon;
        }

        public ViewStateConnection ConvertStateConnection(EntityStateConnection entityStateConnection)
        {
            var viewConnection = new ViewStateConnection()
            {
                Current = entityStateConnection.CurrentConnectionState.ToString(),
                LastActivityDate = entityStateConnection.LastActivityDate.ToString("O"),
                Note = entityStateConnection.Note
            };
            return viewConnection;
        }

        public ViewStateAlarm ConvertStateAlarm(EntityStateAlarm entityStateAlarm)
        {
            var viewAlarm = new ViewStateAlarm()
            {
                ActiveAlarmCount = entityStateAlarm.ActiveAlarmCount,
                LastActiveAlarmDate = entityStateAlarm.LastActiveAlarmDate.ToString("O"),
                Note = entityStateAlarm.Note
            };
            return viewAlarm;
        }

        public ViewStateDevice ConvertStateDevice(EntityStateDevice entityStateDevice)
        {
            var viewDevice = new ViewStateDevice()
            {
                DevicesInAlarmStateCount = entityStateDevice.DevicesInAlarmStateCount,
                Note = entityStateDevice.Note,
                OnlineDevicesCount = entityStateDevice.OnlineDevicesCount,
                TotalDevicesCount = entityStateDevice.TotatDevicesCount
            };
            return viewDevice;
        }

        public ViewStateSystem ConvertStateSystem(EntityStateSystem entityStateSystem)
        {
            var viewSystem = new ViewStateSystem()
            {
                Note = entityStateSystem.Note,
                ActiveSystemsCount = entityStateSystem.ActiveSystemsCount,
                TotalSystemsCount = entityStateSystem.TotalSystemsCount
            };
            return viewSystem;
        }

        private ViewStateFacilityParameter ConvertParameter(EntityStateFacilityParameter entityStateFacilityParameter)
        {
            var viewParam = new ViewStateFacilityParameter()
            {
                Key = entityStateFacilityParameter.Key,
                KeyName = entityStateFacilityParameter.KeyName,
                Note = entityStateFacilityParameter.Note,
                ParameterAtDate = entityStateFacilityParameter.ParameterAtDate.ToString("O"),
                Value = entityStateFacilityParameter.Value,
                ValueName = entityStateFacilityParameter.ValueName
            };
            return viewParam;
        }


        public ViewFacilityCommand ConvertCommand(EntityFacilityCommand entityFacilityCommands)
        {
            var viewCommand = new ViewFacilityCommand()
            {
                FacilityId = entityFacilityCommands.FacilityId,
                CommandId = entityFacilityCommands.CommandId,
                Name = entityFacilityCommands.Name,
                Note = entityFacilityCommands.Note
            };
            return viewCommand;
        }

        public ViewStateCommonExt ConvertExtCommon(EntityStateCommonExt entityStateCommon)
        {
            var viewCommonExt = new ViewStateCommonExt()
            {
                Current = entityStateCommon.Current.ToString(),
                Name = entityStateCommon.Name,
                Note = entityStateCommon.Note,
                StateAtDate = entityStateCommon.StateAtDate.ToString("O")
            };
            return viewCommonExt;
        }

        public ViewStateConnectionExt ConvertExtConnection(EntityStateConnectionExt entityStateConnection)
        {
            var viewConnectionExt = new ViewStateConnectionExt()
            {
                Current = entityStateConnection.CurrentConnectionState.ToString(),
                LastActivityDate = entityStateConnection.LastActivityDate.ToString("O"),
                Note = entityStateConnection.Note
            };
            return viewConnectionExt;
        }

        public ViewStateAlarmExt ConvertExtAlarm(EntityStateAlarmExt entityStateAlarm)
        {
            var viewAlarmExt = new ViewStateAlarmExt()
            {
                AlarmId = entityStateAlarm.AlarmId,
                AlarmState = entityStateAlarm.AlarmState.ToString(),
                AlarmType = entityStateAlarm.AlarmType,
                DateCreate = entityStateAlarm.DateCreate.ToString("O"),
                ConfirmationDate = entityStateAlarm.ConfirmationDate.ToString("O"),
                CloseDate = entityStateAlarm.CloseDate.ToString("O"),
                Name = entityStateAlarm.Name,
                Note = entityStateAlarm.Note,
                SourceName = entityStateAlarm.SourceName
            };
            return viewAlarmExt;
        }

        public ViewStateDeviceExt ConvertExtDevice(EntityStateDeviceExt entityStateDevice)
        {
            var viewDeviceExt = new ViewStateDeviceExt()
            {
                Name = entityStateDevice.Name,
                Note = entityStateDevice.Note
            };
            return viewDeviceExt;
        }

        public ViewStateSystemExt ConvertExtSystem(EntityStateSystemExt entityStateSystem)
        {
            var viewSystemExt = new ViewStateSystemExt()
            {
                Name = entityStateSystem.Name,
                Note = entityStateSystem.Note
            };
            return viewSystemExt;
        }
    }
}
