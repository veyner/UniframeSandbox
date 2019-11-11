using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.EntityObjects
{
    internal class DbInitialzer
    {
        public static void Seed()
        {
            using (var context = new FacilityContext())
            {
                var facility1Coordinates = new EntityCoordinates()
                {
                    CoordinatesId = new Guid("{16B088ED-A2F2-48D9-9869-DA525D21541D}"),
                    Lat = 0,
                    Long = 0,
                };
                if (!context.Coordinates.Contains(facility1Coordinates))
                {
                    context.Coordinates.Add(facility1Coordinates);
                }

                var facility1 = new EntityFacility()
                {
                    FacilityId = new Guid("{8CFA0F3A-67E5-47CB-A0B2-7412E13CC314}"),
                    Name = "New Facility - 1",
                    Description = "test",
                    CoordinatesId = facility1Coordinates.CoordinatesId
                };
                if (!context.Facilities.Contains(facility1))
                {
                    context.Facilities.Add(facility1);
                }

                var facilityCommand1 = new EntityFacilityCommand()
                {
                    CommandId = new Guid("{137A300F-591F-4E52-BE06-C799B0C53F9B}"),
                    FacilityId = facility1.FacilityId,
                    Name = "test command",
                    Note = "test command note"
                };
                if(!context.FacilityCommands.Contains(facilityCommand1))
                {
                    context.FacilityCommands.Add(facilityCommand1);
                }
                var facilityCommand2 = new EntityFacilityCommand()
                {
                    CommandId = new Guid("{5C83B1C5-D52F-4CF8-ADDD-00BEFCBB91EA}"),
                    FacilityId = facility1.FacilityId,
                    Name = "test command 2 ",
                    Note = "test command note 2 "
                };
                if (!context.FacilityCommands.Contains(facilityCommand2))
                {
                    context.FacilityCommands.Add(facilityCommand2);
                }

                var state1 = new EntityFacilityState()
                {
                    FacilityID = facility1.FacilityId,
                    StateId = new Guid("{CAD91B9A-5C92-4D10-ABE1-A2B23C82D483}")
                };
                if(!context.States.Contains(state1))
                {
                    context.States.Add(state1);
                }

                var stateCom1 = new EntityStateCommon()
                {
                    StateId = state1.StateId,
                    Current = EntityStateCommon.CurrentCommonState.normal,
                    Name = "Test Name",
                    Note = "Nope",
                    StateCommonId = new Guid("{803555C5-45D2-49A8-9C21-7A7DC74FAD1C}"),
                    StateAtDate = DateTime.Now,
                };
                
                if (!context.StateCommons.Contains(stateCom1))
                {
                    context.StateCommons.Add(stateCom1);
                }

                var stateDevice1 = new EntityStateDevice()
                {
                    StateId = state1.StateId,
                    StateDeviceId = new Guid("{DC153542-D359-4E4A-8FEC-5F720C084F86}"),
                    Note = "Test device note",
                    DevicesInAlarmStateCount = 1,
                    OnlineDevicesCount = 1,
                    TotatDevicesCount =2
                };
                if(!context.StateDevices.Contains(stateDevice1))
                {
                    context.StateDevices.Add(stateDevice1);
                }

                var stateConnect1 = new EntityStateConnection()
                {
                    StateId = state1.StateId,
                    ConnectionId = new Guid("{511977BB-C995-441A-B558-980F5CBC0B76}"),
                    CurrentConnectionState = EntityStateConnection.ConnectionState.online,
                    LastActivityDate = DateTime.Now,
                    Note = "test note"
                };
                if(!context.StateConnections.Contains(stateConnect1))
                {
                    context.StateConnections.Add(stateConnect1);
                }

                var stateSystem1 = new EntityStateSystem()
                {
                    StateId = state1.StateId,
                    StateSystemId = new Guid("{E514DEAC-0A03-4122-B0EA-B23D1EA83EBB}"),
                    ActiveSystemsCount = 1,
                    TotalSystemsCount = 2,
                    Note = "note"
                };
                if(!context.StateSystems.Contains(stateSystem1))
                {
                    context.StateSystems.Add(stateSystem1);
                }

                var stateAlarm1 = new EntityStateAlarm()
                {
                    StateId = state1.StateId,
                    AlarmId = new Guid("{8F4EDC33-7F19-4D21-BDCF-81138AAF6E4A}"),
                    ActiveAlarmCount = 3,
                    LastActiveAlarmDate = DateTime.Now,
                    Note = "test alarm note"
                    
                };
                if(!context.StateAlarms.Contains(stateAlarm1))
                {
                    context.StateAlarms.Add(stateAlarm1);
                }
                var stateParam1 = new EntityStateFacilityParameter()
                {
                    StateId = state1.StateId,
                    Key = "test key",
                    KeyName = "test key name",
                    Note = "test note",
                    ParameterAtDate = DateTime.Now,
                    StateFacilityParamId = new Guid("{4B0FA9F6-2568-43E6-9BBF-2978060BB40A}"),
                    Value = "test value",
                    ValueName = "test value name"
                };
                if(!context.StateFacilityParameters.Contains(stateParam1))
                {
                    context.StateFacilityParameters.Add(stateParam1);
                }
                var stateParam2 = new EntityStateFacilityParameter()
                {
                    StateId = state1.StateId,
                    Key = "test key 2",
                    KeyName = "test key name 2 ",
                    Note = "test note2 ",
                    ParameterAtDate = DateTime.Now,
                    StateFacilityParamId = new Guid("{06AFB832-4BF5-4754-BE50-28D9EF958D7A}"),
                    Value = "test value 2",
                    ValueName = "test value name 2"
                };
                if (!context.StateFacilityParameters.Contains(stateParam2))
                {
                    context.StateFacilityParameters.Add(stateParam2);
                }

                var commonExt = new EntityStateCommonExt()
                {
                    Current = EntityStateCommonExt.CurrentCommonState.normal,
                    Name = "test ext name",
                    Note = "text ext note",
                    FacilityId = facility1.FacilityId,
                    StateAtDate = DateTime.Now,
                    StateCommonId =  new Guid("{925F9EF3-0718-4BA6-80C4-D4A773432865}")
                };
                if(!context.StateCommonsExt.Contains(commonExt))
                {
                    context.StateCommonsExt.Add(commonExt);
                }
                var alarmExt = new EntityStateAlarmExt()
                {
                    AlarmId = new Guid("{06B06A1A-6B70-4AB4-947C-47F978C58717}"),
                    AlarmState = EntityStateAlarmExt.CurrentAlarmState.New,
                    AlarmType = "test type",
                    CloseDate = DateTime.Now,
                    DateCreate = DateTime.Now,
                    ConfirmationDate = DateTime.Now,
                    FacilityId = facility1.FacilityId,
                    Name = "test name",
                    Note = "test note",
                    SourceName = "test source name"
                };
                if(!context.StateAlarmsExt.Contains(alarmExt))
                {
                    context.StateAlarmsExt.Add(alarmExt);
                }
                var connectionExt = new EntityStateConnectionExt()
                {
                    ConnectionID = new Guid("{69A28B42-8CE0-4994-8B14-1BCE49E815EB}"),
                    CurrentConnectionState = EntityStateConnectionExt.ConnectionState.online,
                    FacilityId = facility1.FacilityId,
                    LastActivityDate = DateTime.Now,
                    Note = "test note 1"
                };
                if(!context.StateConnectionsExt.Contains(connectionExt))
                {
                    context.StateConnectionsExt.Add(connectionExt);
                }
                var systemExt = new EntityStateSystemExt()
                {
                    Note = "test note 1 ",
                    FacilityId = facility1.FacilityId,
                    Name = "test name1",
                    StateSystemId = new Guid ("{F1B6E280-14A9-4B69-8E6C-353E087C849C}")
                };
                if(!context.StateSystemsExt.Contains(systemExt))
                {
                    context.StateSystemsExt.Add(systemExt);
                }
                var deviceExt = new EntityStateDeviceExt()
                {
                    FacilityId = facility1.FacilityId,
                    Name = "test name",
                    Note = "new note",
                    StateDeviceId = new Guid ("{F8926226-973F-4521-9876-E20C4C86C459}")
                };
                if(!context.StateDevicesExt.Contains(deviceExt))
                {
                    context.StateDevicesExt.Add(deviceExt);
                }

                context.SaveChanges();
            }
        }
    }
}
