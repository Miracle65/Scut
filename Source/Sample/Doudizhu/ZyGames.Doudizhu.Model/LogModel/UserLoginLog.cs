﻿//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由Codesmith工具生成。
// 此文件的更改可能会导致不正确的行为，如果
// 重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using ProtoBuf;
using ZyGames.Framework.Common;
using ZyGames.Framework.Collection;
using ZyGames.Framework.Model;


namespace ZyGames.Doudizhu.Model
{
    /// <summary>
    /// 
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Log, "UserLoginLog")]
    public class UserLoginLog : ShareEntity
    {
        #region auto-generated static method
        static UserLoginLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserLoginLog));
        }
        #endregion
        /// <summary>
        /// </summary>
        public UserLoginLog()
            : base(AccessLevel.WriteOnly)
        {
            
        }        
        /// <summary>
        /// </summary>
        public UserLoginLog(int iD)
            : this()
        {
            _iD = iD;
        }

        #region 自动生成属性
        private int _iD;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("ID", IsKey = true, IsIdentity = true)]
        public int ID
        {
            get
            {
                return _iD;
            } 
        }
        private string _sessionID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("SessionID")]
        public string SessionID
        {
            set
            {
                SetChange("SessionID", value);
            }
        }
        private short _mobileType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("MobileType")]
        public short MobileType
        {
            set
            {
                SetChange("MobileType", value);
            }
        }
        private short _screenX;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("ScreenX")]
        public short ScreenX
        {
            set
            {
                SetChange("ScreenX", value);
            }
        }
        private short _screenY;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("ScreenY")]
        public short ScreenY
        {
            set
            {
                SetChange("ScreenY", value);
            }
        }
        private string _retailId;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("RetailId")]
        public string RetailId
        {
            set
            {
                SetChange("RetailId", value);
            }
        }
        private string _model;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("Model")]
        public string Model
        {
            set
            {
                SetChange("Model", value);
            }
        }
        private short _netWork;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("NetWork")]
        public short NetWork
        {
            set
            {
                SetChange("NetWork", value);
            }
        }
        private string _userId;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("UserId")]
        public string UserId
        {
            set
            {
                SetChange("UserId", value);
            }
        }
        private DateTime _addTime;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("AddTime")]
        public DateTime AddTime
        {
            set
            {
                SetChange("AddTime", value);
            }
        }
        private int _state;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(11)]
        [EntityField("State")]
        public int State
        {
            set
            {
                SetChange("State", value);
            }
        }
        private string _deviceID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(12)]
        [EntityField("DeviceID")]
        public string DeviceID
        {
            set
            {
                SetChange("DeviceID", value);
            }
        }
        private string _ip;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(13)]
        [EntityField("Ip")]
        public string Ip
        {
            set
            {
                SetChange("Ip", value);
            }
        }
        private string _pid;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(14)]
        [EntityField("Pid")]
        public string Pid
        {
            set
            {
                SetChange("Pid", value);
            }
        }
        private short _userLv;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(15)]
        [EntityField("UserLv")]
        public short UserLv
        {
            set
            {
                SetChange("UserLv", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "ID": return _iD;
                    case "SessionID": return _sessionID;
                    case "MobileType": return _mobileType;
                    case "ScreenX": return _screenX;
                    case "ScreenY": return _screenY;
                    case "RetailId": return _retailId;
                    case "Model": return _model;
                    case "NetWork": return _netWork;
                    case "UserId": return _userId;
                    case "AddTime": return _addTime;
                    case "State": return _state;
                    case "DeviceID": return _deviceID;
                    case "Ip": return _ip;
                    case "Pid": return _pid;
                    case "UserLv": return _userLv;
					default: throw new ArgumentException(string.Format("UserLoginLog index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "ID": 
                        _iD = value.ToInt();
                        break; 
                    case "SessionID": 
                        _sessionID = value.ToNotNullString();
                        break; 
                    case "MobileType": 
                        _mobileType = value.ToShort();
                        break; 
                    case "ScreenX": 
                        _screenX = value.ToShort();
                        break; 
                    case "ScreenY": 
                        _screenY = value.ToShort();
                        break; 
                    case "RetailId": 
                        _retailId = value.ToNotNullString();
                        break; 
                    case "Model": 
                        _model = value.ToNotNullString();
                        break; 
                    case "NetWork": 
                        _netWork = value.ToShort();
                        break; 
                    case "UserId": 
                        _userId = value.ToNotNullString();
                        break; 
                    case "AddTime": 
                        _addTime = value.ToDateTime();
                        break; 
                    case "State": 
                        _state = value.ToInt();
                        break; 
                    case "DeviceID": 
                        _deviceID = value.ToNotNullString();
                        break; 
                    case "Ip": 
                        _ip = value.ToNotNullString();
                        break; 
                    case "Pid": 
                        _pid = value.ToNotNullString();
                        break; 
                    case "UserLv": 
                        _userLv = value.ToShort();
                        break; 
					default: throw new ArgumentException(string.Format("UserLoginLog index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
        

	}
}