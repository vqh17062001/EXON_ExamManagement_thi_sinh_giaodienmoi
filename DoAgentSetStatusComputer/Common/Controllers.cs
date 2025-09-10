using DAO.DataProvider;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Data.Entity;
using BUS;

namespace EXONSYSTEM.Common
{
	public class Controllers
	{
		private static Controllers instance;
		public static Controllers Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Controllers();
				}
				return instance;
			}
		}
		private Controllers() { }
	
	}
}
