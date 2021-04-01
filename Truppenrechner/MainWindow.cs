using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Gdk;
using Gtk;
using Microsoft.Win32;

public partial class MainWindow : Gtk.Window
{
    //Variablen
    double marchCapacity;
    double marchPower;

    int march = 1;

    //Infantry (Troops, Power, Percent, Calculate)
    double[] infantry = new double[4] { 1, 3, 0, 0 };

    //Driver (Troops, Power, Percent, Calculate)
    double[] driver = new double[4] { 1, 3, 0, 0 };

    //Hunter (Troops, Power, Percent, Calculate)
    double[] hunter = new double[4] { 1, 3, 0, 0 };

    //Troops + Power
    string[,] troops = new string[16, 2]
    {
                { "T1", "3" },
                { "T2", "4" },
                { "T3", "6" },
                { "T4", "9" },
                { "T5", "13" },
                { "T6", "20" },
                { "T7", "28" },
                { "T8", "38" },
                { "T9", "50" },
                { "T10", "66" },
                { "T10*", "71" },
                { "T10**", "76" },
                { "T10***", "83" },
                { "T10****", "88" },
                { "T10*****", "94" },
                { "T11", "114" },
    };

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    //March choice 1
    protected void OnRbnMarch1Pressed(object sender, EventArgs e)
    {
        march = 1;

        if (textMarchCapa1.Buffer.Text == "0")
        {
            clearEntry();
        }
        else
        {
            clearEntry();
            changeEntry();
        }
    }

    //March choice 2
    protected void OnRbnMarch2Pressed(object sender, EventArgs e)
    {
        march = 2;

        if (textMarchCapa2.Buffer.Text == "0")
        {
            clearEntry();
        }
        else
        {
            clearEntry();
            changeEntry();
        }
    }

    //March choice 3
    protected void OnRbnMarch3Pressed(object sender, EventArgs e)
    {
        march = 3;

        if (textMarchCapa3.Buffer.Text == "0")
        {
            clearEntry();
        }
        else
        {
            clearEntry();
            changeEntry();
        }
    }


    //Dropdown Infantry
    protected void OnCbxInfantryTroopsChanged(object sender, EventArgs e)
    {
        for (int i = 0; i < troops.Length - 1; i++)
        {
            if (cbxInfantryTroops.ActiveText == troops[i, 0])
            {
                infantry[1] = Convert.ToDouble(troops[i, 1]);
                break;
            }
        }
    }

    //Dropdown Driver
    protected void OnCbxDriverTroopsChanged(object sender, EventArgs e)
    {
        for (int i = 0; i < troops.Length - 1; i++)
        {
            if (cbxDriverTroops.ActiveText == troops[i, 0])
            {
                driver[1] = Convert.ToDouble(troops[i, 1]);
                break;
            }
        }
    }

    //Dropdown Hunter
    protected void OnCbxHunterTroopsChanged(object sender, EventArgs e)
    {
        for (int i = 0; i < troops.Length - 1; i++)
        {
            if (cbxHunterTroops.ActiveText == troops[i, 0])
            {
                hunter[1] = Convert.ToDouble(troops[i, 1]);
                break;
            }
        }
    }


    //Insert values in specific march
    protected void OnButtonNextMarchClicked(object sender, EventArgs e)
    {

        switch (march)
        {
            case 2:
                saveValue();
                calculateValue();
                insertValue();
                break;

            case 3:
                saveValue();
                calculateValue();
                insertValue();
                break;

            default:
                saveValue();
                calculateValue();
                insertValue();
                break;
        }
    }

    private void saveValue()
    {
        //Capacity
        try
        {
            marchCapacity = Convert.ToDouble(entryCapacity.Text);
            //entryMarchOneCapacity.IsEditable = false;
            entryCapacity.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));

        }
        catch
        {
            entryCapacity.IsEditable = true;
            entryCapacity.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
        }

        //Power
        try
        {
            marchPower = Convert.ToDouble(entryPower.Text);
            //entryMarchOnePower.IsEditable = false;
            entryPower.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));
        }
        catch
        {
            entryPower.IsEditable = true;
            entryPower.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
        }

        //Infantry Troops
        try
        {
            infantry[0] = Convert.ToDouble(entryInfantryTroops.Text);
            entryInfantryTroops.IsEditable = false;
            entryInfantryTroops.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));
        }
        catch (Exception)
        {
            entryInfantryTroops.IsEditable = true;
            entryInfantryTroops.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
        }

        //Driver Troops
        try
        {
            driver[0] = Convert.ToDouble(entryDriverTroops.Text);
            entryDriverTroops.IsEditable = false;
            entryDriverTroops.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));
        }
        catch (Exception)
        {
            entryDriverTroops.IsEditable = true;
            entryDriverTroops.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
        }

        //Hunter Troops
        try
        {
            hunter[0] = Convert.ToDouble(entryHunterTroops.Text);
            entryHunterTroops.IsEditable = false;
            entryHunterTroops.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));
        }
        catch (Exception)
        {
            entryHunterTroops.IsEditable = true;
            entryHunterTroops.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
        }

        //Infantry Formation
        try
        {
            infantry[2] = Convert.ToDouble(entryInfantryFormation.Text);
            //entryInfantryFormation.IsEditable = false;
            entryInfantryFormation.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));
        }
        catch
        {
            infantry[2] = 0;
            entryInfantryFormation.IsEditable = true;
            entryInfantryFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
        }

        //Driver Formation
        try
        {
            driver[2] = Convert.ToDouble(entryDriverFormation.Text);
            //entryDriverFormation.IsEditable = false;
            entryDriverFormation.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));
        }
        catch
        {
            driver[2] = 0;
            entryDriverFormation.IsEditable = true;
            entryDriverFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
        }

        //Hunter Formation
        try
        {
            hunter[2] = Convert.ToDouble(entryHunterFormation.Text);
            //entryHunterFormation.IsEditable = false;
            entryHunterFormation.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));
        }
        catch
        {
            hunter[2] = 0;
            entryHunterFormation.IsEditable = true;
            entryHunterFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
        }
    }

    private void calculateValue()
    {
        infantry[3] = Convert.ToInt32((marchPower * (infantry[2] / 100)) / infantry[1]);
        driver[3] = Convert.ToInt32((marchPower * (driver[2] / 100)) / driver[1]);
        hunter[3] = Convert.ToInt32((marchPower * (hunter[2] / 100)) / hunter[1]);

        switch (march)
        {
            case 2:
                textMarchInf2.Buffer.Text = Convert.ToString(infantry[3]);
                textMarchDriv2.Buffer.Text = Convert.ToString(driver[3]);
                textMarchHun2.Buffer.Text = Convert.ToString(hunter[3]);
                break;

            case 3:
                textMarchInf3.Buffer.Text = Convert.ToString(infantry[3]);
                textMarchDriv3.Buffer.Text = Convert.ToString(driver[3]);
                textMarchHun3.Buffer.Text = Convert.ToString(hunter[3]);
                break;

            default:
                textMarchInf1.Buffer.Text = Convert.ToString(infantry[3]);
                textMarchDriv1.Buffer.Text = Convert.ToString(driver[3]);
                textMarchHun1.Buffer.Text = Convert.ToString(hunter[3]);
                break;
        }

    }

    private void insertValue()
    {
        switch (march)
        {
            case 2:
                textMarchCapa2.Buffer.Text = Convert.ToString(marchCapacity);
                textMarchPow2.Buffer.Text = Convert.ToString(marchPower);
                textMarchForm2.Buffer.Text = Convert.ToString(infantry[2] + "/" + driver[2] + "/" + hunter[2]);
                break;

            case 3:
                textMarchCapa3.Buffer.Text = Convert.ToString(marchCapacity);
                textMarchPow3.Buffer.Text = Convert.ToString(marchPower);
                textMarchForm3.Buffer.Text = Convert.ToString(infantry[2] + "/" + driver[2] + "/" + hunter[2]);
                break;

            default:
                textMarchCapa1.Buffer.Text = Convert.ToString(marchCapacity);
                textMarchPow1.Buffer.Text = Convert.ToString(marchPower);
                textMarchForm1.Buffer.Text = Convert.ToString(infantry[2] + "/" + driver[2] + "/" + hunter[2]);
                break;
        }

        //Missing Infantry
        if (infantry[0] < (Convert.ToDouble(textMarchInf1.Buffer.Text) + Convert.ToDouble(textMarchInf2.Buffer.Text) + Convert.ToDouble(textMarchInf3.Buffer.Text)))
        {
            lblMissingTroops.Visible = true;
            textMissingInf.Buffer.Text = Convert.ToString((Convert.ToInt32(textMarchInf1.Buffer.Text) + Convert.ToInt32(textMarchInf2.Buffer.Text) + Convert.ToInt32(textMarchInf3.Buffer.Text)) - infantry[0] + " fehlen!");
            textMissingInf.ModifyText(StateType.Normal, new Gdk.Color(255, 0, 0));
        }

        //Missing Driver
        if (driver[0] < (Convert.ToDouble(textMarchDriv1.Buffer.Text) + Convert.ToDouble(textMarchDriv2.Buffer.Text) + Convert.ToDouble(textMarchDriv3.Buffer.Text)))
        {
            lblMissingTroops.Visible = true;
            textMissingDriv.Buffer.Text = Convert.ToString((Convert.ToDouble(textMarchDriv1.Buffer.Text) + Convert.ToDouble(textMarchDriv2.Buffer.Text) + Convert.ToDouble(textMarchDriv3.Buffer.Text)) - driver[0] + " fehlen!");
            textMissingDriv.ModifyText(StateType.Normal, new Gdk.Color(255, 0, 0));
        }

        //Missing Hunter
        if (hunter[0] < (Convert.ToDouble(textMarchHun1.Buffer.Text) + Convert.ToDouble(textMarchHun2.Buffer.Text) + Convert.ToDouble(textMarchHun3.Buffer.Text)))
        {
            lblMissingTroops.Visible = true;
            textMissingHun.Buffer.Text = Convert.ToString((Convert.ToDouble(textMarchHun1.Buffer.Text) + Convert.ToDouble(textMarchHun2.Buffer.Text) + Convert.ToDouble(textMarchHun3.Buffer.Text)) - hunter[0] + " fehlen!");
            textMissingHun.ModifyText(StateType.Normal, new Gdk.Color(255, 0, 0));
        }
    }

    private void clearEntry()
    {
        entryInfantryFormation.DeleteText(0, -1);
        entryInfantryFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
        entryInfantryFormation.IsEditable = true;

        entryDriverFormation.DeleteText(0, -1);
        entryDriverFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
        entryDriverFormation.IsEditable = true;

        entryHunterFormation.DeleteText(0, -1);
        entryHunterFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
        entryDriverFormation.IsEditable = true;

        entryCapacity.DeleteText(0, -1);
        entryCapacity.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
        entryCapacity.IsEditable = true;

        entryPower.DeleteText(0, -1);
        entryPower.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
        entryPower.IsEditable = true;
    }

    private void changeEntry()
    {
        if (march == 2)
        {
            var formation = textMarchForm2.Buffer.Text;
            var form = formation.Split('/');

            entryCapacity.InsertText(textMarchCapa2.Buffer.Text);
            entryCapacity.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryCapacity.IsEditable = true;

            entryPower.InsertText(textMarchPow2.Buffer.Text);
            entryPower.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryPower.IsEditable = true;

            entryInfantryFormation.InsertText(form[0]);
            entryInfantryFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryInfantryFormation.IsEditable = true;

            entryDriverFormation.InsertText(form[1]);
            entryDriverFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryDriverFormation.IsEditable = true;

            entryHunterFormation.InsertText(form[2]);
            entryHunterFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryHunterFormation.IsEditable = true;
        }
        else if (march == 3)
        {
            var formation = textMarchForm3.Buffer.Text;
            var form = formation.Split('/');

            entryCapacity.InsertText(textMarchCapa3.Buffer.Text);
            entryCapacity.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryCapacity.IsEditable = true;

            entryPower.InsertText(textMarchPow3.Buffer.Text);
            entryPower.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryPower.IsEditable = true;

            entryInfantryFormation.InsertText(form[0]);
            entryInfantryFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryInfantryFormation.IsEditable = true;

            entryDriverFormation.InsertText(form[1]);
            entryDriverFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryDriverFormation.IsEditable = true;

            entryHunterFormation.InsertText(form[2]);
            entryHunterFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryHunterFormation.IsEditable = true;
        }
        else
        {
            var formation = textMarchForm1.Buffer.Text;
            var form = formation.Split('/');

            entryCapacity.InsertText(textMarchCapa1.Buffer.Text);
            entryCapacity.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryCapacity.IsEditable = true;

            entryPower.InsertText(textMarchPow1.Buffer.Text);
            entryPower.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryPower.IsEditable = true;

            entryInfantryFormation.InsertText(form[0]);
            entryInfantryFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryInfantryFormation.IsEditable = true;

            entryDriverFormation.InsertText(form[1]);
            entryDriverFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryDriverFormation.IsEditable = true;

            entryHunterFormation.InsertText(form[2]);
            entryHunterFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
            entryHunterFormation.IsEditable = true;
        }


    }

    //Clear all
    protected void OnButtonResetClicked(object sender, EventArgs e)
    {
        Console.WriteLine("Reset");
        //Variablen
        marchCapacity = 0;
        marchPower = 0;
        march = 1;

        //Array reset
        for (int i = 0; i < infantry.Length - 1; i++)
        {
            if (i == 0)
                infantry[i] = 1;
            else if (i == 1)
                infantry[i] = 3;
            else
                infantry[i] = 0;
        }

        for (int i = 0; i < driver.Length - 1; i++)
        {
            if (i == 0)
                driver[i] = 1;
            else if (i == 1)
                driver[i] = 3;
            else
                driver[i] = 0;
        }

        for (int i = 0; i < hunter.Length - 1; i++)
        {
            if (i == 0)
                hunter[i] = 1;
            else if (i == 1)
                hunter[i] = 3;
            else
                hunter[i] = 0;
        }

        //Entries reset
        entryInfantryTroops.DeleteText(0, -1);
        entryInfantryTroops.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
        entryInfantryTroops.IsEditable = true;

        entryDriverTroops.DeleteText(0, -1);
        entryDriverTroops.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
        entryDriverTroops.IsEditable = true;

        entryHunterTroops.DeleteText(0, -1);
        entryHunterTroops.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
        entryHunterTroops.IsEditable = true;

        entryInfantryFormation.DeleteText(0, -1);
        entryInfantryFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
        entryInfantryFormation.IsEditable = true;

        entryDriverFormation.DeleteText(0, -1);
        entryDriverFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
        entryDriverFormation.IsEditable = true;

        entryHunterFormation.DeleteText(0, -1);
        entryHunterFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
        entryDriverFormation.IsEditable = true;

        entryCapacity.DeleteText(0, -1);
        entryCapacity.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
        entryCapacity.IsEditable = true;

        entryPower.DeleteText(0, -1);
        entryPower.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
        entryPower.IsEditable = true;

        //Textview reset
        textMarchCapa1.Buffer.Text = "0";
        textMarchPow1.Buffer.Text = "0";
        textMarchForm1.Buffer.Text = "  /    /  ";
        textMarchInf1.Buffer.Text = "0";
        textMarchDriv1.Buffer.Text = "0";
        textMarchHun1.Buffer.Text = "0";

        textMarchCapa2.Buffer.Text = "0";
        textMarchPow2.Buffer.Text = "0";
        textMarchForm2.Buffer.Text = "  /    /  ";
        textMarchInf2.Buffer.Text = "0";
        textMarchDriv2.Buffer.Text = "0";
        textMarchHun2.Buffer.Text = "0";

        textMarchCapa3.Buffer.Text = "0";
        textMarchPow3.Buffer.Text = "0";
        textMarchForm3.Buffer.Text = "  /    /  ";
        textMarchInf3.Buffer.Text = "0";
        textMarchDriv3.Buffer.Text = "0";
        textMarchHun3.Buffer.Text = "0";

        lblMissingTroops.Visible = false;
        textMissingInf.Buffer.Text = " ";
        textMissingDriv.Buffer.Text = " ";
        textMissingHun.Buffer.Text = " ";
    }
}

// Backup
//public partial class MainWindow : Gtk.Window
//{
//    //Variablen
//    double marchCapacity;
//    double marchPower;

//    int march = 1;

//    //Infantry (Troops, Power, Percent, Calculate)
//    double[] infantry = new double[4] { 1, 3, 0, 0 };

//    //Driver (Troops, Power, Percent, Calculate)
//    double[] driver = new double[4] { 1, 3, 0, 0 };

//    //Hunter (Troops, Power, Percent, Calculate)
//    double[] hunter = new double[4] { 1, 3, 0, 0 };

//    //Troops + Power
//    string[,] troops = new string[16, 2]
//    {
//                { "T1", "3" },
//                { "T2", "4" },
//                { "T3", "6" },
//                { "T4", "9" },
//                { "T5", "13" },
//                { "T6", "20" },
//                { "T7", "28" },
//                { "T8", "38" },
//                { "T9", "50" },
//                { "T10", "66" },
//                { "T10*", "71" },
//                { "T10**", "76" },
//                { "T10***", "83" },
//                { "T10****", "88" },
//                { "T10*****", "94" },
//                { "T11", "114" },
//    };

//    public MainWindow() : base(Gtk.WindowType.Toplevel)
//    {
//        Build();
//    }

//    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
//    {
//        Application.Quit();
//        a.RetVal = true;
//    }

//    //March choice 1
//    protected void OnRbnMarch1Pressed(object sender, EventArgs e)
//    {
//        march = 1;

//        if (textMarchCapa1.Buffer.Text == "0")
//        {
//            clearEntry();
//        }
//        else
//        {
//            clearEntry();
//            changeEntry();
//        }
//    }

//    //March choice 2
//    protected void OnRbnMarch2Pressed(object sender, EventArgs e)
//    {
//        march = 2;

//        if (textMarchCapa2.Buffer.Text == "0")
//        {
//            clearEntry();
//        }
//        else
//        {
//            clearEntry();
//            changeEntry();
//        }
//    }

//    //March choice 3
//    protected void OnRbnMarch3Pressed(object sender, EventArgs e)
//    {
//        march = 3;

//        if (textMarchCapa3.Buffer.Text == "0")
//        {
//            clearEntry();
//        }
//        else
//        {
//            clearEntry();
//            changeEntry();
//        }
//    }


//    //Dropdown Infantry
//    protected void OnCbxInfantryTroopsChanged(object sender, EventArgs e)
//    {
//        for (int i = 0; i < troops.Length - 1; i++)
//        {
//            if (cbxInfantryTroops.ActiveText == troops[i, 0])
//            {
//                infantry[1] = Convert.ToDouble(troops[i, 1]);
//                break;
//            }
//        }
//    }

//    //Dropdown Driver
//    protected void OnCbxDriverTroopsChanged(object sender, EventArgs e)
//    {
//        for (int i = 0; i < troops.Length - 1; i++)
//        {
//            if (cbxDriverTroops.ActiveText == troops[i, 0])
//            {
//                driver[1] = Convert.ToDouble(troops[i, 1]);
//                break;
//            }
//        }
//    }

//    //Dropdown Hunter
//    protected void OnCbxHunterTroopsChanged(object sender, EventArgs e)
//    {
//        for (int i = 0; i < troops.Length - 1; i++)
//        {
//            if (cbxHunterTroops.ActiveText == troops[i, 0])
//            {
//                hunter[1] = Convert.ToDouble(troops[i, 1]);
//                break;
//            }
//        }
//    }


//    //Insert values in specific march
//    protected void OnButtonNextMarchClicked(object sender, EventArgs e)
//    {

//        switch (march)
//        {
//            case 2:
//                saveValue();
//                calculateValue();
//                insertValue();
//                break;

//            case 3:
//                saveValue();
//                calculateValue();
//                insertValue();
//                break;

//            default:
//                saveValue();
//                calculateValue();
//                insertValue();
//                break;
//        }
//    }

//    private void saveValue()
//    {
//        //Capacity
//        try
//        {
//            marchCapacity = Convert.ToDouble(entryCapacity.Text);
//            //entryMarchOneCapacity.IsEditable = false;
//            entryCapacity.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));

//        }
//        catch
//        {
//            entryCapacity.IsEditable = true;
//            entryCapacity.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
//        }

//        //Power
//        try
//        {
//            marchPower = Convert.ToDouble(entryPower.Text);
//            //entryMarchOnePower.IsEditable = false;
//            entryPower.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));
//        }
//        catch
//        {
//            entryPower.IsEditable = true;
//            entryPower.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
//        }

//        //Infantry Troops
//        try
//        {
//            infantry[0] = Convert.ToDouble(entryInfantryTroops.Text);
//            entryInfantryTroops.IsEditable = false;
//            entryInfantryTroops.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));
//        }
//        catch (Exception)
//        {
//            entryInfantryTroops.IsEditable = true;
//            entryInfantryTroops.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
//        }

//        //Driver Troops
//        try
//        {
//            driver[0] = Convert.ToDouble(entryDriverTroops.Text);
//            entryDriverTroops.IsEditable = false;
//            entryDriverTroops.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));
//        }
//        catch (Exception)
//        {
//            entryDriverTroops.IsEditable = true;
//            entryDriverTroops.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
//        }

//        //Hunter Troops
//        try
//        {
//            hunter[0] = Convert.ToDouble(entryHunterTroops.Text);
//            entryHunterTroops.IsEditable = false;
//            entryHunterTroops.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));
//        }
//        catch (Exception)
//        {
//            entryHunterTroops.IsEditable = true;
//            entryHunterTroops.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
//        }

//        //Infantry Formation
//        try
//        {
//            infantry[2] = Convert.ToDouble(entryInfantryFormation.Text);
//            //entryInfantryFormation.IsEditable = false;
//            entryInfantryFormation.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));
//        }
//        catch
//        {
//            infantry[2] = 0;
//            entryInfantryFormation.IsEditable = true;
//            entryInfantryFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
//        }

//        //Driver Formation
//        try
//        {
//            driver[2] = Convert.ToDouble(entryDriverFormation.Text);
//            //entryDriverFormation.IsEditable = false;
//            entryDriverFormation.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));
//        }
//        catch
//        {
//            driver[2] = 0;
//            entryDriverFormation.IsEditable = true;
//            entryDriverFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
//        }

//        //Hunter Formation
//        try
//        {
//            hunter[2] = Convert.ToDouble(entryHunterFormation.Text);
//            //entryHunterFormation.IsEditable = false;
//            entryHunterFormation.ModifyBase(StateType.Normal, new Gdk.Color(0, 255, 0));
//        }
//        catch
//        {
//            hunter[2] = 0;
//            entryHunterFormation.IsEditable = true;
//            entryHunterFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 0, 0));
//        }
//    }

//    private void calculateValue()
//    {
//        infantry[3] = Convert.ToInt32((marchPower * (infantry[2] / 100)) / infantry[1]);
//        driver[3] = Convert.ToInt32((marchPower * (driver[2] / 100)) / driver[1]);
//        hunter[3] = Convert.ToInt32((marchPower * (hunter[2] / 100)) / hunter[1]);

//        switch (march)
//        {
//            case 2:
//                textMarchInf2.Buffer.Text = Convert.ToString(infantry[3]);
//                textMarchDriv2.Buffer.Text = Convert.ToString(driver[3]);
//                textMarchHun2.Buffer.Text = Convert.ToString(hunter[3]);
//                break;

//            case 3:
//                textMarchInf3.Buffer.Text = Convert.ToString(infantry[3]);
//                textMarchDriv3.Buffer.Text = Convert.ToString(driver[3]);
//                textMarchHun3.Buffer.Text = Convert.ToString(hunter[3]);
//                break;

//            default:
//                textMarchInf1.Buffer.Text = Convert.ToString(infantry[3]);
//                textMarchDriv1.Buffer.Text = Convert.ToString(driver[3]);
//                textMarchHun1.Buffer.Text = Convert.ToString(hunter[3]);
//                break;
//        }

//    }

//    private void insertValue()
//    {
//        switch (march)
//        {
//            case 2:
//                textMarchCapa2.Buffer.Text = Convert.ToString(marchCapacity);
//                textMarchPow2.Buffer.Text = Convert.ToString(marchPower);
//                textMarchForm2.Buffer.Text = Convert.ToString(infantry[2] + "/" + driver[2] + "/" + hunter[2]);
//                break;

//            case 3:
//                textMarchCapa3.Buffer.Text = Convert.ToString(marchCapacity);
//                textMarchPow3.Buffer.Text = Convert.ToString(marchPower);
//                textMarchForm3.Buffer.Text = Convert.ToString(infantry[2] + "/" + driver[2] + "/" + hunter[2]);
//                break;

//            default:
//                textMarchCapa1.Buffer.Text = Convert.ToString(marchCapacity);
//                textMarchPow1.Buffer.Text = Convert.ToString(marchPower);
//                textMarchForm1.Buffer.Text = Convert.ToString(infantry[2] + "/" + driver[2] + "/" + hunter[2]);
//                break;
//        }

//        //Missing Infantry
//        if (infantry[0] < (Convert.ToDouble(textMarchInf1.Buffer.Text) + Convert.ToDouble(textMarchInf2.Buffer.Text) + Convert.ToDouble(textMarchInf3.Buffer.Text)))
//        {
//            lblMissingTroops.Visible = true;
//            textMissingInf.Buffer.Text = Convert.ToString((Convert.ToInt32(textMarchInf1.Buffer.Text) + Convert.ToInt32(textMarchInf2.Buffer.Text) + Convert.ToInt32(textMarchInf3.Buffer.Text)) - infantry[0] + " fehlen!");
//            textMissingInf.ModifyText(StateType.Normal, new Gdk.Color(255, 0, 0));
//        }

//        //Missing Driver
//        if (driver[0] < (Convert.ToDouble(textMarchDriv1.Buffer.Text) + Convert.ToDouble(textMarchDriv2.Buffer.Text) + Convert.ToDouble(textMarchDriv3.Buffer.Text)))
//        {
//            lblMissingTroops.Visible = true;
//            textMissingDriv.Buffer.Text = Convert.ToString((Convert.ToDouble(textMarchDriv1.Buffer.Text) + Convert.ToDouble(textMarchDriv2.Buffer.Text) + Convert.ToDouble(textMarchDriv3.Buffer.Text)) - driver[0] + " fehlen!");
//            textMissingDriv.ModifyText(StateType.Normal, new Gdk.Color(255, 0, 0));
//        }

//        //Missing Hunter
//        if (hunter[0] < (Convert.ToDouble(textMarchHun1.Buffer.Text) + Convert.ToDouble(textMarchHun2.Buffer.Text) + Convert.ToDouble(textMarchHun3.Buffer.Text)))
//        {
//            lblMissingTroops.Visible = true;
//            textMissingHun.Buffer.Text = Convert.ToString((Convert.ToDouble(textMarchHun1.Buffer.Text) + Convert.ToDouble(textMarchHun2.Buffer.Text) + Convert.ToDouble(textMarchHun3.Buffer.Text)) - hunter[0] + " fehlen!");
//            textMissingHun.ModifyText(StateType.Normal, new Gdk.Color(255, 0, 0));
//        }
//    }

//    private void clearEntry()
//    {
//        entryInfantryFormation.DeleteText(0, -1);
//        entryInfantryFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//        entryInfantryFormation.IsEditable = true;

//        entryDriverFormation.DeleteText(0, -1);
//        entryDriverFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//        entryDriverFormation.IsEditable = true;

//        entryHunterFormation.DeleteText(0, -1);
//        entryHunterFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//        entryDriverFormation.IsEditable = true;

//        entryCapacity.DeleteText(0, -1);
//        entryCapacity.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//        entryCapacity.IsEditable = true;

//        entryPower.DeleteText(0, -1);
//        entryPower.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//        entryPower.IsEditable = true;
//    }

//    private void changeEntry()
//    {
//        if (march == 2)
//        {
//            var formation = textMarchForm2.Buffer.Text;
//            var form = formation.Split('/');

//            entryCapacity.InsertText(textMarchCapa2.Buffer.Text);
//            entryCapacity.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryCapacity.IsEditable = true;

//            entryPower.InsertText(textMarchPow2.Buffer.Text);
//            entryPower.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryPower.IsEditable = true;

//            entryInfantryFormation.InsertText(form[0]);
//            entryInfantryFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryInfantryFormation.IsEditable = true;

//            entryDriverFormation.InsertText(form[1]);
//            entryDriverFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryDriverFormation.IsEditable = true;

//            entryHunterFormation.InsertText(form[2]);
//            entryHunterFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryHunterFormation.IsEditable = true;
//        }
//        else if (march == 3)
//        {
//            var formation = textMarchForm3.Buffer.Text;
//            var form = formation.Split('/');

//            entryCapacity.InsertText(textMarchCapa3.Buffer.Text);
//            entryCapacity.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryCapacity.IsEditable = true;

//            entryPower.InsertText(textMarchPow3.Buffer.Text);
//            entryPower.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryPower.IsEditable = true;

//            entryInfantryFormation.InsertText(form[0]);
//            entryInfantryFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryInfantryFormation.IsEditable = true;

//            entryDriverFormation.InsertText(form[1]);
//            entryDriverFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryDriverFormation.IsEditable = true;

//            entryHunterFormation.InsertText(form[2]);
//            entryHunterFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryHunterFormation.IsEditable = true;
//        }
//        else
//        {
//            var formation = textMarchForm1.Buffer.Text;
//            var form = formation.Split('/');

//            entryCapacity.InsertText(textMarchCapa1.Buffer.Text);
//            entryCapacity.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryCapacity.IsEditable = true;

//            entryPower.InsertText(textMarchPow1.Buffer.Text);
//            entryPower.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryPower.IsEditable = true;

//            entryInfantryFormation.InsertText(form[0]);
//            entryInfantryFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryInfantryFormation.IsEditable = true;

//            entryDriverFormation.InsertText(form[1]);
//            entryDriverFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryDriverFormation.IsEditable = true;

//            entryHunterFormation.InsertText(form[2]);
//            entryHunterFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//            entryHunterFormation.IsEditable = true;
//        }


//    }

//    //Clear all
//    protected void OnButtonResetClicked(object sender, EventArgs e)
//    {
//        Console.WriteLine("Reset");
//        //Variablen
//        marchCapacity = 0;
//        marchPower = 0;
//        march = 1;

//        //Array reset
//        for (int i = 0; i < infantry.Length - 1; i++)
//        {
//            if (i == 0)
//                infantry[i] = 1;
//            else if (i == 1)
//                infantry[i] = 3;
//            else
//                infantry[i] = 0;
//        }

//        for (int i = 0; i < driver.Length - 1; i++)
//        {
//            if (i == 0)
//                driver[i] = 1;
//            else if (i == 1)
//                driver[i] = 3;
//            else
//                driver[i] = 0;
//        }

//        for (int i = 0; i < hunter.Length - 1; i++)
//        {
//            if (i == 0)
//                hunter[i] = 1;
//            else if (i == 1)
//                hunter[i] = 3;
//            else
//                hunter[i] = 0;
//        }

//        //Entries reset
//        entryInfantryTroops.DeleteText(0, -1);
//        entryInfantryTroops.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//        entryInfantryTroops.IsEditable = true;

//        entryDriverTroops.DeleteText(0, -1);
//        entryDriverTroops.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//        entryDriverTroops.IsEditable = true;

//        entryHunterTroops.DeleteText(0, -1);
//        entryHunterTroops.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//        entryHunterTroops.IsEditable = true;

//        entryInfantryFormation.DeleteText(0, -1);
//        entryInfantryFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//        entryInfantryFormation.IsEditable = true;

//        entryDriverFormation.DeleteText(0, -1);
//        entryDriverFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//        entryDriverFormation.IsEditable = true;

//        entryHunterFormation.DeleteText(0, -1);
//        entryHunterFormation.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//        entryDriverFormation.IsEditable = true;

//        entryCapacity.DeleteText(0, -1);
//        entryCapacity.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//        entryCapacity.IsEditable = true;

//        entryPower.DeleteText(0, -1);
//        entryPower.ModifyBase(StateType.Normal, new Gdk.Color(255, 255, 255));
//        entryPower.IsEditable = true;

//        //Textview reset
//        textMarchCapa1.Buffer.Text = "0";
//        textMarchPow1.Buffer.Text = "0";
//        textMarchForm1.Buffer.Text = "  /    /  ";
//        textMarchInf1.Buffer.Text = "0";
//        textMarchDriv1.Buffer.Text = "0";
//        textMarchHun1.Buffer.Text = "0";

//        textMarchCapa2.Buffer.Text = "0";
//        textMarchPow2.Buffer.Text = "0";
//        textMarchForm2.Buffer.Text = "  /    /  ";
//        textMarchInf2.Buffer.Text = "0";
//        textMarchDriv2.Buffer.Text = "0";
//        textMarchHun2.Buffer.Text = "0";

//        textMarchCapa3.Buffer.Text = "0";
//        textMarchPow3.Buffer.Text = "0";
//        textMarchForm3.Buffer.Text = "  /    /  ";
//        textMarchInf3.Buffer.Text = "0";
//        textMarchDriv3.Buffer.Text = "0";
//        textMarchHun3.Buffer.Text = "0";

//        lblMissingTroops.Visible = false;
//        textMissingInf.Buffer.Text = " ";
//        textMissingDriv.Buffer.Text = " ";
//        textMissingHun.Buffer.Text = " ";
//    }
//}