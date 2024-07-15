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
        myModbusClient2 = new ModbusClient("127.0.0.1",503);
        myModbusClient2.Connect();
        myModbusClient3 = new ModbusClient("127.0.0.1",504);
        myModbusClient3.Connect();
        myModbusClient4 = new ModbusClient("127.0.0.1",505);
        myModbusClient4.Connect();
        myModbusClient5 = new ModbusClient("127.0.0.1",506);
        myModbusClient5.Connect();
        myModbusClient6 = new ModbusClient("127.0.0.1",507);
        myModbusClient6.Connect();
        myModbusClient7 = new ModbusClient("127.0.0.1",508);
        myModbusClient7.Connect();
        myModbusClient8 = new ModbusClient("127.0.0.1",509);
        myModbusClient8.Connect();
        myModbusClient9 = new ModbusClient("127.0.0.1",510);
        myModbusClient9.Connect();
        myModbusClient10 = new ModbusClient("127.0.0.1",511);
        myModbusClient10.Connect();
        
        myTask1 = new PeriodicTask(MB_Lectura_Server1_Task, 100, LogicObject);
        myTask1.Start();
        
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
        myTask1.Dispose();
        
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

        int[] readHoldingRegisters2 = myModbusClient2.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox11").Text=readHoldingRegisters2[0].ToString();
        Owner.Get<TextBox>("TextBox12").Text=readHoldingRegisters2[1].ToString();
        Owner.Get<TextBox>("TextBox13").Text=readHoldingRegisters2[2].ToString();
        Owner.Get<TextBox>("TextBox14").Text=readHoldingRegisters2[3].ToString();
        Owner.Get<TextBox>("TextBox15").Text=readHoldingRegisters2[4].ToString();
        Owner.Get<TextBox>("TextBox16").Text=readHoldingRegisters2[5].ToString();
        Owner.Get<TextBox>("TextBox17").Text=readHoldingRegisters2[6].ToString();
        Owner.Get<TextBox>("TextBox18").Text=readHoldingRegisters2[7].ToString();
        Owner.Get<TextBox>("TextBox19").Text=readHoldingRegisters2[8].ToString();
        Owner.Get<TextBox>("TextBox20").Text=readHoldingRegisters2[9].ToString();

        int[] readHoldingRegisters3 = myModbusClient3.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox21").Text=readHoldingRegisters3[0].ToString();
        Owner.Get<TextBox>("TextBox22").Text=readHoldingRegisters3[1].ToString();
        Owner.Get<TextBox>("TextBox23").Text=readHoldingRegisters3[2].ToString();
        Owner.Get<TextBox>("TextBox24").Text=readHoldingRegisters3[3].ToString();
        Owner.Get<TextBox>("TextBox25").Text=readHoldingRegisters3[4].ToString();
        Owner.Get<TextBox>("TextBox26").Text=readHoldingRegisters3[5].ToString();
        Owner.Get<TextBox>("TextBox27").Text=readHoldingRegisters3[6].ToString();
        Owner.Get<TextBox>("TextBox28").Text=readHoldingRegisters3[7].ToString();
        Owner.Get<TextBox>("TextBox29").Text=readHoldingRegisters3[8].ToString();
        Owner.Get<TextBox>("TextBox30").Text=readHoldingRegisters3[9].ToString();

        int[] readHoldingRegisters4 = myModbusClient4.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox31").Text=readHoldingRegisters4[0].ToString();
        Owner.Get<TextBox>("TextBox32").Text=readHoldingRegisters4[1].ToString();
        Owner.Get<TextBox>("TextBox33").Text=readHoldingRegisters4[2].ToString();
        Owner.Get<TextBox>("TextBox34").Text=readHoldingRegisters4[3].ToString();
        Owner.Get<TextBox>("TextBox35").Text=readHoldingRegisters4[4].ToString();
        Owner.Get<TextBox>("TextBox36").Text=readHoldingRegisters4[5].ToString();
        Owner.Get<TextBox>("TextBox37").Text=readHoldingRegisters4[6].ToString();
        Owner.Get<TextBox>("TextBox38").Text=readHoldingRegisters4[7].ToString();
        Owner.Get<TextBox>("TextBox39").Text=readHoldingRegisters4[8].ToString();
        Owner.Get<TextBox>("TextBox40").Text=readHoldingRegisters4[9].ToString();

        int[] readHoldingRegisters5 = myModbusClient5.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox41").Text=readHoldingRegisters5[0].ToString();
        Owner.Get<TextBox>("TextBox42").Text=readHoldingRegisters5[1].ToString();
        Owner.Get<TextBox>("TextBox43").Text=readHoldingRegisters5[2].ToString();
        Owner.Get<TextBox>("TextBox44").Text=readHoldingRegisters5[3].ToString();
        Owner.Get<TextBox>("TextBox45").Text=readHoldingRegisters5[4].ToString();
        Owner.Get<TextBox>("TextBox46").Text=readHoldingRegisters5[5].ToString();
        Owner.Get<TextBox>("TextBox47").Text=readHoldingRegisters5[6].ToString();
        Owner.Get<TextBox>("TextBox48").Text=readHoldingRegisters5[7].ToString();
        Owner.Get<TextBox>("TextBox49").Text=readHoldingRegisters5[8].ToString();
        Owner.Get<TextBox>("TextBox50").Text=readHoldingRegisters5[9].ToString();

        int[] readHoldingRegisters6 = myModbusClient6.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox51").Text=readHoldingRegisters6[0].ToString();
        Owner.Get<TextBox>("TextBox52").Text=readHoldingRegisters6[1].ToString();
        Owner.Get<TextBox>("TextBox53").Text=readHoldingRegisters6[2].ToString();
        Owner.Get<TextBox>("TextBox54").Text=readHoldingRegisters6[3].ToString();
        Owner.Get<TextBox>("TextBox55").Text=readHoldingRegisters6[4].ToString();
        Owner.Get<TextBox>("TextBox56").Text=readHoldingRegisters6[5].ToString();
        Owner.Get<TextBox>("TextBox57").Text=readHoldingRegisters6[6].ToString();
        Owner.Get<TextBox>("TextBox58").Text=readHoldingRegisters6[7].ToString();
        Owner.Get<TextBox>("TextBox59").Text=readHoldingRegisters6[8].ToString();
        Owner.Get<TextBox>("TextBox60").Text=readHoldingRegisters6[9].ToString();

        int[] readHoldingRegisters7 = myModbusClient7.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox61").Text=readHoldingRegisters7[0].ToString();
        Owner.Get<TextBox>("TextBox62").Text=readHoldingRegisters7[1].ToString();
        Owner.Get<TextBox>("TextBox63").Text=readHoldingRegisters7[2].ToString();
        Owner.Get<TextBox>("TextBox64").Text=readHoldingRegisters7[3].ToString();
        Owner.Get<TextBox>("TextBox65").Text=readHoldingRegisters7[4].ToString();
        Owner.Get<TextBox>("TextBox66").Text=readHoldingRegisters7[5].ToString();
        Owner.Get<TextBox>("TextBox67").Text=readHoldingRegisters7[6].ToString();
        Owner.Get<TextBox>("TextBox68").Text=readHoldingRegisters7[7].ToString();
        Owner.Get<TextBox>("TextBox69").Text=readHoldingRegisters7[8].ToString();
        Owner.Get<TextBox>("TextBox70").Text=readHoldingRegisters7[9].ToString();

         int[] readHoldingRegisters8 = myModbusClient8.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox71").Text=readHoldingRegisters8[0].ToString();
        Owner.Get<TextBox>("TextBox72").Text=readHoldingRegisters8[1].ToString();
        Owner.Get<TextBox>("TextBox73").Text=readHoldingRegisters8[2].ToString();
        Owner.Get<TextBox>("TextBox74").Text=readHoldingRegisters8[3].ToString();
        Owner.Get<TextBox>("TextBox75").Text=readHoldingRegisters8[4].ToString();
        Owner.Get<TextBox>("TextBox76").Text=readHoldingRegisters8[5].ToString();
        Owner.Get<TextBox>("TextBox77").Text=readHoldingRegisters8[6].ToString();
        Owner.Get<TextBox>("TextBox78").Text=readHoldingRegisters8[7].ToString();
        Owner.Get<TextBox>("TextBox79").Text=readHoldingRegisters8[8].ToString();
        Owner.Get<TextBox>("TextBox80").Text=readHoldingRegisters8[9].ToString();

        int[] readHoldingRegisters9 = myModbusClient9.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox81").Text=readHoldingRegisters9[0].ToString();
        Owner.Get<TextBox>("TextBox82").Text=readHoldingRegisters9[1].ToString();
        Owner.Get<TextBox>("TextBox83").Text=readHoldingRegisters9[2].ToString();
        Owner.Get<TextBox>("TextBox84").Text=readHoldingRegisters9[3].ToString();
        Owner.Get<TextBox>("TextBox85").Text=readHoldingRegisters9[4].ToString();
        Owner.Get<TextBox>("TextBox86").Text=readHoldingRegisters9[5].ToString();
        Owner.Get<TextBox>("TextBox87").Text=readHoldingRegisters9[6].ToString();
        Owner.Get<TextBox>("TextBox88").Text=readHoldingRegisters9[7].ToString();
        Owner.Get<TextBox>("TextBox89").Text=readHoldingRegisters9[8].ToString();
        Owner.Get<TextBox>("TextBox90").Text=readHoldingRegisters9[9].ToString();

        int[] readHoldingRegisters10 = myModbusClient10.ReadHoldingRegisters(0,10);
        Owner.Get<TextBox>("TextBox91").Text=readHoldingRegisters10[0].ToString();
        Owner.Get<TextBox>("TextBox92").Text=readHoldingRegisters10[1].ToString();
        Owner.Get<TextBox>("TextBox93").Text=readHoldingRegisters10[2].ToString();
        Owner.Get<TextBox>("TextBox94").Text=readHoldingRegisters10[3].ToString();
        Owner.Get<TextBox>("TextBox95").Text=readHoldingRegisters10[4].ToString();
        Owner.Get<TextBox>("TextBox96").Text=readHoldingRegisters10[5].ToString();
        Owner.Get<TextBox>("TextBox97").Text=readHoldingRegisters10[6].ToString();
        Owner.Get<TextBox>("TextBox98").Text=readHoldingRegisters10[7].ToString();
        Owner.Get<TextBox>("TextBox99").Text=readHoldingRegisters10[8].ToString();
        Owner.Get<TextBox>("TextBox100").Text=readHoldingRegisters10[9].ToString();
    }

 
}
