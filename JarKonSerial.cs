﻿using JarKonApplication;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarKonApplication
{
	public class JarKonSerial
	{

		public string[] ComAvailableList;
		public string ComSelected = "";
		public System.IO.Ports.SerialPort serial;
		public string Baudrate = "115200";
		public bool isOpenedPort = false;

		private JarKonDevApplication form;


		public JarKonSerial(System.IO.Ports.SerialPort serial, JarKonDevApplication form)
		{
			this.serial = serial;

			this.form = form;

			SerialPortComRefresh();
		}


		public void SerialPortComRefresh()
		{

			ComAvailableList = SerialPort.GetPortNames();

		}


		public bool SerialPortComOpen()
		{
			if (ComSelected == null || ComSelected == "")
			{
				// Wrong COM
				String errorMessage = "Error: Empty portname\n";
				Console.WriteLine(errorMessage);
				form.AppendTextSerialData("[Application] " + errorMessage);
				return false;
			}
			else
			{
				// Good COM
				serial.PortName = ComSelected;
				try
				{
					serial.Open();
					Console.WriteLine("Opened serial port");
					isOpenedPort = true;
					return true;
				}
				catch (Exception e)
				{
					String errorMessage = "Error with port opening.\n";
					Console.WriteLine(errorMessage + e.Message);
					form.AppendTextSerialData("[Programmer] " + errorMessage);
					return false;
				}
				
				
			}
			

		}


		public void SetComSelected(string com)
		{
			ComSelected = com;
		}

		public void SetBaudrateSelected(string baudrate)
		{
			Baudrate = baudrate;
		}



		public void SerialPortComClose()
		{
			serial.Close();
			Console.WriteLine("Closed Serial port");
			isOpenedPort = false;
		}


		public void DataReceived()
		{
			string receivedMessage = "";

			receivedMessage += serial.ReadLine();

			form.AppendTextSerialData(receivedMessage);

			form.CheckFwUpateMessageAndSend(receivedMessage);
		}


		public String SendMessage(String message)
		{
			String logMessage;

			if (isOpenedPort)
			{
				try
				{
					serial.WriteLine(message);
				}
				catch (Exception e)
				{
					Log.SendErrorLog(e.Message);
					logMessage = "[Application] Port error\n";
				}
				
				logMessage = "[Application] Successful sent message\n";
				
			}
			else
			{
				logMessage = "[Application] Cannot send message, because there is not opened port\n";
			}

			return logMessage;
		}


	}
}