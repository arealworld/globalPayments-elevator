using GlobalPayments.Elevator.Domain;
using GlobalPayments.Elevator.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GlobalPayments.Elevator.Domain.Enums;

namespace GlobalPayments.Elevator.UI
{
    public partial class FormElevator : Form
    {
        private ElevatorService _elevatorService;
        private BackgroundWorker backgroundWorker1;

        #region "Constructor"

        public FormElevator()
        {
            InitializeComponent();

            Domain.Elevator elevator = new Domain.Elevator();
            _elevatorService = new ElevatorService(elevator);

            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }

        #endregion

        #region "Control events"

        private void FormElevator_Load(object sender, EventArgs e)
        {
            try
            {
                _elevatorService.Initialize();
                _elevatorService.InitializeListOfRequest();

                RefreshCurrentElevatorState();

                elevatorTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listOfRequests_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                ElevatorRequest item = (ElevatorRequest)listOfRequests.Items[e.Index];

                e.DrawBackground();
                Graphics g = e.Graphics;

                g.FillRectangle(new SolidBrush(Color.LightCoral), e.Bounds);

                if (item.Completed)
                {
                    g.FillRectangle(new SolidBrush(Color.LightGreen), e.Bounds);
                }

                e.Graphics.DrawString(item.Description, e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void elevatorTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                RefreshCurrentElevatorState();
                RefreshBlockedButtons();
                RefreshRequestsList();

                if (!backgroundWorker1.IsBusy)
                {
                    progressBarElevator.Visible = true;
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _elevatorService.MoveElevator();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                progressBarElevator.Visible = false;
                RefreshRequestsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region "Methods"

        public void RefreshCurrentElevatorState()
        {
            lblState.Text = _elevatorService.GetCurrentState().ToString();
            lblCurrentFloor.Text = _elevatorService.GetCurrentFloor().ToString();
            lblDirection.Text = _elevatorService.GetCurrentDirection().ToString();
        }

        public void RefreshRequestsList()
        {
            listOfRequests.DataSource = _elevatorService.GetRequests();
            listOfRequests.DisplayMember = "Description";
            listOfRequests.ValueMember = "Floor";
            listOfRequests.DrawMode = DrawMode.OwnerDrawFixed;
        }

        public void AddElevatorRequest(Button button, bool isInternal, ElevatorFloor floor, ElevatorDirection direction)
        {
            try
            {
                button.BackColor = Color.LightCoral;

                _elevatorService.AddElevatorRequest(isInternal, floor, direction);

                RefreshRequestsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RefreshBlockedButtons()
        {
            //external buttons
            ResetButtonColor(btn1Up, _elevatorService.IsButtonBlocked(false, ElevatorFloor.First, ElevatorDirection.Up));

            ResetButtonColor(btn2Down, _elevatorService.IsButtonBlocked(false, ElevatorFloor.Second, ElevatorDirection.Down));
            ResetButtonColor(btn2Up, _elevatorService.IsButtonBlocked(false, ElevatorFloor.Second, ElevatorDirection.Up));

            ResetButtonColor(btn3Down, _elevatorService.IsButtonBlocked(false, ElevatorFloor.Third, ElevatorDirection.Down));
            ResetButtonColor(btn3Up, _elevatorService.IsButtonBlocked(false, ElevatorFloor.Third, ElevatorDirection.Up));

            ResetButtonColor(btn4Down, _elevatorService.IsButtonBlocked(false, ElevatorFloor.Fourth, ElevatorDirection.Down));
            ResetButtonColor(btn4Up, _elevatorService.IsButtonBlocked(false, ElevatorFloor.Fourth, ElevatorDirection.Up));

            ResetButtonColor(btn5Down, _elevatorService.IsButtonBlocked(false, ElevatorFloor.Fifth, ElevatorDirection.Down));

            //internal buttons
            ResetButtonColor(btnFloor1, _elevatorService.IsButtonBlocked(true, ElevatorFloor.First, ElevatorDirection.None));
            ResetButtonColor(btnFloor2, _elevatorService.IsButtonBlocked(true, ElevatorFloor.Second, ElevatorDirection.None));
            ResetButtonColor(btnFloor3, _elevatorService.IsButtonBlocked(true, ElevatorFloor.Third, ElevatorDirection.None));
            ResetButtonColor(btnFloor4, _elevatorService.IsButtonBlocked(true, ElevatorFloor.Fourth, ElevatorDirection.None));
            ResetButtonColor(btnFloor5, _elevatorService.IsButtonBlocked(true, ElevatorFloor.Fifth, ElevatorDirection.None));
        }

        public void ResetButtonColor(Button button, bool isBlocked)
        {
            if (!isBlocked)
            {
                button.BackColor = Color.LightGray;
            }
        }

        #endregion

        #region "External buttons"

        private void btn1Up_Click(object sender, EventArgs e)
        {
            AddElevatorRequest(btn1Up, false, ElevatorFloor.First, ElevatorDirection.Up);
        }

        private void btn2Down_Click(object sender, EventArgs e)
        {
            AddElevatorRequest(btn2Down, false, ElevatorFloor.Second, ElevatorDirection.Down);
        }

        private void btn2Up_Click(object sender, EventArgs e)
        {
            AddElevatorRequest(btn2Up, false, ElevatorFloor.Second, ElevatorDirection.Up);
        }

        private void btn3Down_Click(object sender, EventArgs e)
        {
            AddElevatorRequest(btn3Down, false, ElevatorFloor.Third, ElevatorDirection.Down);
        }

        private void btn3Up_Click(object sender, EventArgs e)
        {
            AddElevatorRequest(btn3Up, false, ElevatorFloor.Third, ElevatorDirection.Up);
        }

        private void btn4Down_Click(object sender, EventArgs e)
        {
            AddElevatorRequest(btn4Down, false, ElevatorFloor.Fourth, ElevatorDirection.Down);
        }

        private void btn4Up_Click(object sender, EventArgs e)
        {
            AddElevatorRequest(btn4Up, false, ElevatorFloor.Fourth, ElevatorDirection.Up);
        }

        private void btn5Down_Click(object sender, EventArgs e)
        {
            AddElevatorRequest(btn5Down, false, ElevatorFloor.Fifth, ElevatorDirection.Down);
        }

        #endregion

        #region "Internal buttons"

        private void btnFloor1_Click(object sender, EventArgs e)
        {
            AddElevatorRequest(btnFloor1, true, ElevatorFloor.First, ElevatorDirection.None);
        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            AddElevatorRequest(btnFloor2, true, ElevatorFloor.Second, ElevatorDirection.None);
        }

        private void btnFloor3_Click(object sender, EventArgs e)
        {
            AddElevatorRequest(btnFloor3, true, ElevatorFloor.Third, ElevatorDirection.None);
        }

        private void btnFloor4_Click(object sender, EventArgs e)
        {
            AddElevatorRequest(btnFloor4, true, ElevatorFloor.Fourth, ElevatorDirection.None);
        }

        private void btnFloor5_Click(object sender, EventArgs e)
        {
            AddElevatorRequest(btnFloor5, true, ElevatorFloor.Fifth, ElevatorDirection.None);
        }

        #endregion
    }
}
