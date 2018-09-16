using System;
using Csla;

namespace ClassLibrary1
{
	[Serializable]
	public class Class1 : BusinessBase<Class1>
	{
		public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(c => c.Name);
		public string Name
		{
			get { return GetProperty(NameProperty); }
			set { SetProperty(NameProperty, value); }
		}
	}
}
