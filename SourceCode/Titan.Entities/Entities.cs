namespace Titan.Entities
{
	using System.Data;
	using System.Runtime.Serialization;
	using Titan;

	/*
	<system.runtime.serialization>
		<dataContractSerializer>
		  <declaredTypes>
			<add type="Titan.BusinessEnumBase,Titan">
		   </declaredTypes>
		</dataContractSerializer>
	  </system.runtime.serialization>
	*/
	#region enums

	#endregion



	#region UserInfo
	/// <summary>
	/// UserInfo,用户信息表
	/// </summary>
	[DataContract]
	[Table(TableName = "UserInfo", Label = "UserInfo")]
	public partial class UserInfo : Entity
	{

		public UserInfo()
		{
		}
		public UserInfo(string userId)
		{
			this.UserId = userId;
		}

		#region propertys

		private string _UserId;

		/// <summary>
		/// UserId,主键
		/// </summary>
		[DataMember]
		[Column(IsPrimaryKey = true, Length = 20)]
		[MySqlDbType(DbType.String)]
		public string UserId
		{
			get
			{
				return this._UserId ?? string.Empty;
			}
			set
			{
				this._UserId = value;
			}
		}


		private string _UserName;

		/// <summary>
		/// UserName,名称
		/// </summary>
		[DataMember]
		[Column(AllowNull = true, Length = 20)]
		[MySqlDbType(DbType.String)]
		public string UserName
		{
			get
			{
				return this._UserName ?? string.Empty;
			}
			set
			{
				this._UserName = value;
			}
		}


		#endregion

		#region link objects

		#endregion
		public static bool Exists(string userId)
		{
			UserInfo obj = new UserInfo();
			obj.UserId = userId;
			return obj.Exists();
		}
		public static bool Exists(IDbSession session, string userId)
		{
			UserInfo obj = new UserInfo();
			obj.UserId = userId;
			return obj.Exists(session);
		}
		public static bool Exists(IDbSession session, NameMapping tableMapping, string userId)
		{
			UserInfo obj = new UserInfo();
			obj.UserId = userId;
			return obj.Exists(session, tableMapping);
		}
		public static bool Exists(NameMapping tableMapping, string userId)
		{
			UserInfo obj = new UserInfo();
			obj.UserId = userId;
			return obj.Exists(tableMapping);
		}
		public static bool Exists(IConditionExpression conditionExpression)
		{
			UserInfo obj = new UserInfo();
			return obj.ExistsInner(conditionExpression);
		}
		public static bool Exists(IDbSession session, IConditionExpression conditionExpression)
		{
			UserInfo obj = new UserInfo();
			return obj.ExistsInner(session, conditionExpression);
		}
		public static bool Exists(NameMapping tableMapping, IConditionExpression conditionExpression)
		{
			UserInfo obj = new UserInfo();
			return obj.ExistsInner(tableMapping, conditionExpression);
		}
		public static bool Exists(IDbSession session, NameMapping tableMapping, IConditionExpression conditionExpression)
		{
			UserInfo obj = new UserInfo();
			return obj.ExistsInner(session, tableMapping, conditionExpression);
		}
		public static int Delete(string userId)
		{
			UserInfo obj = new UserInfo();
			obj.UserId = userId;
			return obj.Delete();
		}
		public static int Delete(IDbSession session, string userId)
		{
			UserInfo obj = new UserInfo();
			obj.UserId = userId;
			return obj.Delete(session);
		}
		public static int Delete(IDbSession session, NameMapping tableMapping, string userId)
		{
			UserInfo obj = new UserInfo();
			obj.UserId = userId;
			return obj.Delete(session, tableMapping);
		}
		public static int Delete(NameMapping tableMapping, string userId)
		{
			UserInfo obj = new UserInfo();
			obj.UserId = userId;
			return obj.Delete(tableMapping);
		}
		public static int BatchDelete(IConditionExpression conditionExpression)
		{
			UserInfo obj = new UserInfo();
			return obj.BatchDeleteInner(conditionExpression);
		}
		public static int BatchDelete(IDbSession session, IConditionExpression conditionExpression)
		{
			UserInfo obj = new UserInfo();
			return obj.BatchDeleteInner(session, conditionExpression);
		}
		public static int BatchDelete(IDbSession session, NameMapping tableMapping, IConditionExpression conditionExpression)
		{
			UserInfo obj = new UserInfo();
			return obj.BatchDeleteInner(session, tableMapping, conditionExpression);
		}
		public static int BatchDelete(NameMapping tableMapping, IConditionExpression conditionExpression)
		{
			UserInfo obj = new UserInfo();
			return obj.BatchDeleteInner(tableMapping, conditionExpression);
		}
	}
	#endregion

	#region UserInfos

	/// <summary>
	/// UserInfo集合,用户信息表
	/// </summary>
	[DataContract]
	public partial class UserInfos : EntityCollection<UserInfo>
	{
	}
	#endregion


	#region UserInfoProperties
	public static class UserInfoProperties
	{

		static UserInfoProperties()
		{
			_ALL = new ExpressionBuilder("*");
			_UserId = new ExpressionBuilder("UserId");
			_UserName = new ExpressionBuilder("UserName");


		}

		private static ExpressionBuilder _ALL;
		public static ExpressionBuilder ALL { get { return _ALL; } }
		private static ExpressionBuilder _UserId;
		/// <summary>
		/// UserId,主键
		/// </summary>
		public static ExpressionBuilder UserId { get { return _UserId; } }
		private static ExpressionBuilder _UserName;
		/// <summary>
		/// UserName,名称
		/// </summary>
		public static ExpressionBuilder UserName { get { return _UserName; } }



	}
	#endregion
	#region UserInfoDescriptor
	public class UserInfoDescriptor
	{

		public UserInfoDescriptor(string prefix)
		{
			this._Prefix = prefix;
			this._ALL = new ExpressionBuilder(prefix + "*");

			this._UserId = new ExpressionBuilder(prefix + "UserId");
			this._UserName = new ExpressionBuilder(prefix + "UserName");
		}

		private string _Prefix;

		private ExpressionBuilder _ALL;
		public ExpressionBuilder ALL { get { return _ALL; } }
		private ExpressionBuilder _UserId;
		/// <summary>
		/// UserId,主键
		/// </summary>
		public ExpressionBuilder UserId { get { return _UserId; } }
		private ExpressionBuilder _UserName;
		/// <summary>
		/// UserName,名称
		/// </summary>
		public ExpressionBuilder UserName { get { return _UserName; } }



	}
	#endregion

	#region UserAccre
	/// <summary>
	/// UserAccre,用户授权
	/// </summary>
	[DataContract]
	[Table(TableName = "UserAccre", Label = "UserAccre")]
	public partial class UserAccre : Entity
	{

		public UserAccre()
		{
		}
		public UserAccre(string id)
		{
			this.Id = id;
		}

		#region propertys

		private string _Id;

		/// <summary>
		/// Id,主键
		/// </summary>
		[DataMember]
		[Column(IsPrimaryKey = true, Length = 20)]
		[MySqlDbType(DbType.String)]
		public string Id
		{
			get
			{
				return this._Id ?? string.Empty;
			}
			set
			{
				this._Id = value;
			}
		}


		private string _UserId;

		/// <summary>
		/// UserId,外键
		/// </summary>
		[DataMember]
		[Column(AllowNull = true, Length = 20)]
		[MySqlDbType(DbType.String)]
		public string UserId
		{
			get
			{
				return this._UserId ?? string.Empty;
			}
			set
			{
				this._UserId = value;
			}
		}


		private string _OpenId;

		/// <summary>
		/// OpenId,授权标识
		/// </summary>
		[DataMember]
		[Column(AllowNull = true, Length = 30)]
		[MySqlDbType(DbType.String)]
		public string OpenId
		{
			get
			{
				return this._OpenId ?? string.Empty;
			}
			set
			{
				this._OpenId = value;
			}
		}


		#endregion

		#region link objects

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		[Relation("UserId,UserId")]
		public UserInfo UserInfo { get; set; }



		#endregion
		public static bool Exists(string id)
		{
			UserAccre obj = new UserAccre();
			obj.Id = id;
			return obj.Exists();
		}
		public static bool Exists(IDbSession session, string id)
		{
			UserAccre obj = new UserAccre();
			obj.Id = id;
			return obj.Exists(session);
		}
		public static bool Exists(IDbSession session, NameMapping tableMapping, string id)
		{
			UserAccre obj = new UserAccre();
			obj.Id = id;
			return obj.Exists(session, tableMapping);
		}
		public static bool Exists(NameMapping tableMapping, string id)
		{
			UserAccre obj = new UserAccre();
			obj.Id = id;
			return obj.Exists(tableMapping);
		}
		public static bool Exists(IConditionExpression conditionExpression)
		{
			UserAccre obj = new UserAccre();
			return obj.ExistsInner(conditionExpression);
		}
		public static bool Exists(IDbSession session, IConditionExpression conditionExpression)
		{
			UserAccre obj = new UserAccre();
			return obj.ExistsInner(session, conditionExpression);
		}
		public static bool Exists(NameMapping tableMapping, IConditionExpression conditionExpression)
		{
			UserAccre obj = new UserAccre();
			return obj.ExistsInner(tableMapping, conditionExpression);
		}
		public static bool Exists(IDbSession session, NameMapping tableMapping, IConditionExpression conditionExpression)
		{
			UserAccre obj = new UserAccre();
			return obj.ExistsInner(session, tableMapping, conditionExpression);
		}
		public static int Delete(string id)
		{
			UserAccre obj = new UserAccre();
			obj.Id = id;
			return obj.Delete();
		}
		public static int Delete(IDbSession session, string id)
		{
			UserAccre obj = new UserAccre();
			obj.Id = id;
			return obj.Delete(session);
		}
		public static int Delete(IDbSession session, NameMapping tableMapping, string id)
		{
			UserAccre obj = new UserAccre();
			obj.Id = id;
			return obj.Delete(session, tableMapping);
		}
		public static int Delete(NameMapping tableMapping, string id)
		{
			UserAccre obj = new UserAccre();
			obj.Id = id;
			return obj.Delete(tableMapping);
		}
		public static int BatchDelete(IConditionExpression conditionExpression)
		{
			UserAccre obj = new UserAccre();
			return obj.BatchDeleteInner(conditionExpression);
		}
		public static int BatchDelete(IDbSession session, IConditionExpression conditionExpression)
		{
			UserAccre obj = new UserAccre();
			return obj.BatchDeleteInner(session, conditionExpression);
		}
		public static int BatchDelete(IDbSession session, NameMapping tableMapping, IConditionExpression conditionExpression)
		{
			UserAccre obj = new UserAccre();
			return obj.BatchDeleteInner(session, tableMapping, conditionExpression);
		}
		public static int BatchDelete(NameMapping tableMapping, IConditionExpression conditionExpression)
		{
			UserAccre obj = new UserAccre();
			return obj.BatchDeleteInner(tableMapping, conditionExpression);
		}
	}
	#endregion

	#region UserAccres

	/// <summary>
	/// UserAccre集合,用户授权
	/// </summary>
	[DataContract]
	public partial class UserAccres : EntityCollection<UserAccre>
	{
	}
	#endregion


	#region UserAccreProperties
	public static class UserAccreProperties
	{

		static UserAccreProperties()
		{
			_ALL = new ExpressionBuilder("*");
			_Id = new ExpressionBuilder("Id");
			_UserId = new ExpressionBuilder("UserId");
			_OpenId = new ExpressionBuilder("OpenId");


			_UserInfo = new UserInfoDescriptor("UserInfo.");
		}

		private static ExpressionBuilder _ALL;
		public static ExpressionBuilder ALL { get { return _ALL; } }
		private static ExpressionBuilder _Id;
		/// <summary>
		/// Id,主键
		/// </summary>
		public static ExpressionBuilder Id { get { return _Id; } }
		private static ExpressionBuilder _UserId;
		/// <summary>
		/// UserId,外键
		/// </summary>
		public static ExpressionBuilder UserId { get { return _UserId; } }
		private static ExpressionBuilder _OpenId;
		/// <summary>
		/// OpenId,授权标识
		/// </summary>
		public static ExpressionBuilder OpenId { get { return _OpenId; } }



		private static UserInfoDescriptor _UserInfo;
		public static UserInfoDescriptor UserInfo { get { return _UserInfo; } }
	}
	#endregion
	#region UserAccreDescriptor
	public class UserAccreDescriptor
	{

		public UserAccreDescriptor(string prefix)
		{
			this._Prefix = prefix;
			this._ALL = new ExpressionBuilder(prefix + "*");

			this._Id = new ExpressionBuilder(prefix + "Id");
			this._UserId = new ExpressionBuilder(prefix + "UserId");
			this._OpenId = new ExpressionBuilder(prefix + "OpenId");
		}

		private string _Prefix;

		private ExpressionBuilder _ALL;
		public ExpressionBuilder ALL { get { return _ALL; } }
		private ExpressionBuilder _Id;
		/// <summary>
		/// Id,主键
		/// </summary>
		public ExpressionBuilder Id { get { return _Id; } }
		private ExpressionBuilder _UserId;
		/// <summary>
		/// UserId,外键
		/// </summary>
		public ExpressionBuilder UserId { get { return _UserId; } }
		private ExpressionBuilder _OpenId;
		/// <summary>
		/// OpenId,授权标识
		/// </summary>
		public ExpressionBuilder OpenId { get { return _OpenId; } }



		private UserInfoDescriptor _UserInfo;
		public UserInfoDescriptor UserInfo
		{
			get
			{
				if (_UserInfo == null) _UserInfo = new UserInfoDescriptor(this._Prefix + "UserInfo.");
				return _UserInfo;
			}
		}
	}
	#endregion
}
