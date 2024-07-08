#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using EasyModbus;
using FTOptix.RAEtherNetIP;
using FTOptix.CommunicationDriver;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
     PeriodicTask myTask1;
     PeriodicTask myTask2;
     PeriodicTask myTask3;
     PeriodicTask myTask4;
     PeriodicTask myTask5;
    PeriodicTask myTask6;
    PeriodicTask myTask7;
    PeriodicTask myTask8;
    PeriodicTask myTask9;
    PeriodicTask myTask10;



    ModbusClient myModbusClient1;
    ModbusClient myModbusClient2;
    ModbusClient myModbusClient3;
    ModbusClient myModbusClient4;
    ModbusClient myModbusClient5;
    ModbusClient myModbusClient6;
    ModbusClient myModbusClient7;
    ModbusClient myModbusClient8;
    ModbusClient myModbusClient9;
    ModbusClient myModbusClient10;


    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        myModbusClient1 = new ModbusClient("127.0.0.1",502);
        myModbusClient1.Connect();
        myTask1 = new PeriodicTask(MB_Lectura_Server1_Task, 100, LogicObject);
        myTask1.Start();
        
        myModbusClient2 = new ModbusClient("127.0.0.1",503);
        myModbusClient2.Connect();
        myTask2 = new PeriodicTask(MB_Lectura_Server2_Task, 100, LogicObject);
        myTask2.Start();
        
        myModbusClient3 = new ModbusClient("127.0.0.1",504);
        myModbusClient3.Connect();
        myTask3 = new PeriodicTask(MB_Lectura_Server3_Task, 100, LogicObject);
        myTask3.Start();
        
        myModbusClient4 = new ModbusClient("127.0.0.1",505);
        myModbusClient4.Connect();
        myTask4 = new PeriodicTask(MB_Lectura_Server4_Task, 100, LogicObject);
        myTask4.Start();

        myModbusClient5 = new ModbusClient("127.0.0.1",506);
        myModbusClient5.Connect();
        myTask5 = new PeriodicTask(MB_Lectura_Server5_Task, 100, LogicObject);
        myTask5.Start();

        myModbusClient6 = new ModbusClient("127.0.0.1",507);
        myModbusClient6.Connect();
        myTask6= new PeriodicTask(MB_Lectura_Server6_Task, 100, LogicObject);
        myTask6.Start();

        myModbusClient7 = new ModbusClient("127.0.0.1",508);
        myModbusClient7.Connect();
        myTask7= new PeriodicTask(MB_Lectura_Server7_Task, 100, LogicObject);
        myTask7.Start();

        myModbusClient8 = new ModbusClient("127.0.0.1",509);
        myModbusClient8.Connect();
        myTask8= new PeriodicTask(MB_Lectura_Server8_Task, 100, LogicObject);
        myTask8.Start();

        myModbusClient9 = new ModbusClient("127.0.0.1",510);
        myModbusClient9.Connect();
        myTask9= new PeriodicTask(MB_Lectura_Server9_Task, 100, LogicObject);
        myTask9.Start();

        myModbusClient10 = new ModbusClient("127.0.0.1",511);
        myModbusClient10.Connect();
        myTask10= new PeriodicTask(MB_Lectura_Server10_Task, 100, LogicObject);
        myTask10.Start();
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
        myTask1.Dispose();
        myTask2.Dispose();
        myTask3.Dispose();
        myTask4.Dispose();
        myTask5.Dispose();
        myTask6.Dispose();
        myTask7.Dispose();
        myTask8.Dispose();
        myTask9.Dispose();
        myTask10.Dispose();

    }
    private void MB_Lectura_Server1_Task()
    {
        int[] readHoldingRegisters = myModbusClient1.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox1").Text=readHoldingRegisters[0].ToString();
        Owner.Get<TextBox>("TextBox2").Text=readHoldingRegisters[1].ToString();
        Owner.Get<TextBox>("TextBox3").Text=readHoldingRegisters[2].ToString();
        Owner.Get<TextBox>("TextBox4").Text=readHoldingRegisters[3].ToString();
        Owner.Get<TextBox>("TextBox5").Text=readHoldingRegisters[4].ToString();
        Owner.Get<TextBox>("TextBox6").Text=readHoldingRegisters[5].ToString();
        Owner.Get<TextBox>("TextBox7").Text=readHoldingRegisters[6].ToString();
        Owner.Get<TextBox>("TextBox8").Text=readHoldingRegisters[7].ToString();
        Owner.Get<TextBox>("TextBox9").Text=readHoldingRegisters[8].ToString();
        Owner.Get<TextBox>("TextBox10").Text=readHoldingRegisters[9].ToString();
    }

 private void MB_Lectura_Server2_Task()
    {
        int[] readHoldingRegisters = myModbusClient2.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox11").Text=readHoldingRegisters[0].ToString();
        Owner.Get<TextBox>("TextBox12").Text=readHoldingRegisters[1].ToString();
        Owner.Get<TextBox>("TextBox13").Text=readHoldingRegisters[2].ToString();
        Owner.Get<TextBox>("TextBox14").Text=readHoldingRegisters[3].ToString();
        Owner.Get<TextBox>("TextBox15").Text=readHoldingRegisters[4].ToString();
        Owner.Get<TextBox>("TextBox16").Text=readHoldingRegisters[5].ToString();
        Owner.Get<TextBox>("TextBox17").Text=readHoldingRegisters[6].ToString();
        Owner.Get<TextBox>("TextBox18").Text=readHoldingRegisters[7].ToString();
        Owner.Get<TextBox>("TextBox19").Text=readHoldingRegisters[8].ToString();
        Owner.Get<TextBox>("TextBox20").Text=readHoldingRegisters[9].ToString();
    }

private void MB_Lectura_Server3_Task()
    {
        int[] readHoldingRegisters = myModbusClient3.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox21").Text=readHoldingRegisters[0].ToString();
        Owner.Get<TextBox>("TextBox22").Text=readHoldingRegisters[1].ToString();
        Owner.Get<TextBox>("TextBox23").Text=readHoldingRegisters[2].ToString();
        Owner.Get<TextBox>("TextBox24").Text=readHoldingRegisters[3].ToString();
        Owner.Get<TextBox>("TextBox25").Text=readHoldingRegisters[4].ToString();
        Owner.Get<TextBox>("TextBox26").Text=readHoldingRegisters[5].ToString();
        Owner.Get<TextBox>("TextBox27").Text=readHoldingRegisters[6].ToString();
        Owner.Get<TextBox>("TextBox28").Text=readHoldingRegisters[7].ToString();
        Owner.Get<TextBox>("TextBox29").Text=readHoldingRegisters[8].ToString();
        Owner.Get<TextBox>("TextBox30").Text=readHoldingRegisters[9].ToString();
    }

    private void MB_Lectura_Server4_Task()
    {
        int[] readHoldingRegisters = myModbusClient4.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox31").Text=readHoldingRegisters[0].ToString();
        Owner.Get<TextBox>("TextBox32").Text=readHoldingRegisters[1].ToString();
        Owner.Get<TextBox>("TextBox33").Text=readHoldingRegisters[2].ToString();
        Owner.Get<TextBox>("TextBox34").Text=readHoldingRegisters[3].ToString();
        Owner.Get<TextBox>("TextBox35").Text=readHoldingRegisters[4].ToString();
        Owner.Get<TextBox>("TextBox36").Text=readHoldingRegisters[5].ToString();
        Owner.Get<TextBox>("TextBox37").Text=readHoldingRegisters[6].ToString();
        Owner.Get<TextBox>("TextBox38").Text=readHoldingRegisters[7].ToString();
        Owner.Get<TextBox>("TextBox39").Text=readHoldingRegisters[8].ToString();
        Owner.Get<TextBox>("TextBox40").Text=readHoldingRegisters[9].ToString();
    }

     private void MB_Lectura_Server5_Task()
    {
        int[] readHoldingRegisters = myModbusClient5.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox41").Text=readHoldingRegisters[0].ToString();
        Owner.Get<TextBox>("TextBox42").Text=readHoldingRegisters[1].ToString();
        Owner.Get<TextBox>("TextBox43").Text=readHoldingRegisters[2].ToString();
        Owner.Get<TextBox>("TextBox44").Text=readHoldingRegisters[3].ToString();
        Owner.Get<TextBox>("TextBox45").Text=readHoldingRegisters[4].ToString();
        Owner.Get<TextBox>("TextBox46").Text=readHoldingRegisters[5].ToString();
        Owner.Get<TextBox>("TextBox47").Text=readHoldingRegisters[6].ToString();
        Owner.Get<TextBox>("TextBox48").Text=readHoldingRegisters[7].ToString();
        Owner.Get<TextBox>("TextBox49").Text=readHoldingRegisters[8].ToString();
        Owner.Get<TextBox>("TextBox50").Text=readHoldingRegisters[9].ToString();
    }

    private void MB_Lectura_Server6_Task()
    {
        int[] readHoldingRegisters = myModbusClient6.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox51").Text=readHoldingRegisters[0].ToString();
        Owner.Get<TextBox>("TextBox52").Text=readHoldingRegisters[1].ToString();
        Owner.Get<TextBox>("TextBox53").Text=readHoldingRegisters[2].ToString();
        Owner.Get<TextBox>("TextBox54").Text=readHoldingRegisters[3].ToString();
        Owner.Get<TextBox>("TextBox55").Text=readHoldingRegisters[4].ToString();
        Owner.Get<TextBox>("TextBox56").Text=readHoldingRegisters[5].ToString();
        Owner.Get<TextBox>("TextBox57").Text=readHoldingRegisters[6].ToString();
        Owner.Get<TextBox>("TextBox58").Text=readHoldingRegisters[7].ToString();
        Owner.Get<TextBox>("TextBox59").Text=readHoldingRegisters[8].ToString();
        Owner.Get<TextBox>("TextBox60").Text=readHoldingRegisters[9].ToString();
    }

    private void MB_Lectura_Server7_Task()
    {
        int[] readHoldingRegisters = myModbusClient7.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox61").Text=readHoldingRegisters[0].ToString();
        Owner.Get<TextBox>("TextBox62").Text=readHoldingRegisters[1].ToString();
        Owner.Get<TextBox>("TextBox63").Text=readHoldingRegisters[2].ToString();
        Owner.Get<TextBox>("TextBox64").Text=readHoldingRegisters[3].ToString();
        Owner.Get<TextBox>("TextBox65").Text=readHoldingRegisters[4].ToString();
        Owner.Get<TextBox>("TextBox66").Text=readHoldingRegisters[5].ToString();
        Owner.Get<TextBox>("TextBox67").Text=readHoldingRegisters[6].ToString();
        Owner.Get<TextBox>("TextBox68").Text=readHoldingRegisters[7].ToString();
        Owner.Get<TextBox>("TextBox69").Text=readHoldingRegisters[8].ToString();
        Owner.Get<TextBox>("TextBox70").Text=readHoldingRegisters[9].ToString();
    }

    private void MB_Lectura_Server8_Task()
    {
        int[] readHoldingRegisters = myModbusClient8.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox71").Text=readHoldingRegisters[0].ToString();
        Owner.Get<TextBox>("TextBox72").Text=readHoldingRegisters[1].ToString();
        Owner.Get<TextBox>("TextBox73").Text=readHoldingRegisters[2].ToString();
        Owner.Get<TextBox>("TextBox74").Text=readHoldingRegisters[3].ToString();
        Owner.Get<TextBox>("TextBox75").Text=readHoldingRegisters[4].ToString();
        Owner.Get<TextBox>("TextBox76").Text=readHoldingRegisters[5].ToString();
        Owner.Get<TextBox>("TextBox77").Text=readHoldingRegisters[6].ToString();
        Owner.Get<TextBox>("TextBox78").Text=readHoldingRegisters[7].ToString();
        Owner.Get<TextBox>("TextBox79").Text=readHoldingRegisters[8].ToString();
        Owner.Get<TextBox>("TextBox80").Text=readHoldingRegisters[9].ToString();
    }

    private void MB_Lectura_Server9_Task()
    {
        int[] readHoldingRegisters = myModbusClient9.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox81").Text=readHoldingRegisters[0].ToString();
        Owner.Get<TextBox>("TextBox82").Text=readHoldingRegisters[1].ToString();
        Owner.Get<TextBox>("TextBox83").Text=readHoldingRegisters[2].ToString();
        Owner.Get<TextBox>("TextBox84").Text=readHoldingRegisters[3].ToString();
        Owner.Get<TextBox>("TextBox85").Text=readHoldingRegisters[4].ToString();
        Owner.Get<TextBox>("TextBox86").Text=readHoldingRegisters[5].ToString();
        Owner.Get<TextBox>("TextBox87").Text=readHoldingRegisters[6].ToString();
        Owner.Get<TextBox>("TextBox88").Text=readHoldingRegisters[7].ToString();
        Owner.Get<TextBox>("TextBox89").Text=readHoldingRegisters[8].ToString();
        Owner.Get<TextBox>("TextBox90").Text=readHoldingRegisters[9].ToString();
    }

private void MB_Lectura_Server10_Task()
    {
        int[] readHoldingRegisters = myModbusClient10.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox91").Text=readHoldingRegisters[0].ToString();
        Owner.Get<TextBox>("TextBox92").Text=readHoldingRegisters[1].ToString();
        Owner.Get<TextBox>("TextBox93").Text=readHoldingRegisters[2].ToString();
        Owner.Get<TextBox>("TextBox94").Text=readHoldingRegisters[3].ToString();
        Owner.Get<TextBox>("TextBox95").Text=readHoldingRegisters[4].ToString();
        Owner.Get<TextBox>("TextBox96").Text=readHoldingRegisters[5].ToString();
        Owner.Get<TextBox>("TextBox97").Text=readHoldingRegisters[6].ToString();
        Owner.Get<TextBox>("TextBox98").Text=readHoldingRegisters[7].ToString();
        Owner.Get<TextBox>("TextBox99").Text=readHoldingRegisters[8].ToString();
        Owner.Get<TextBox>("TextBox100").Text=readHoldingRegisters[9].ToString();
    }
}
