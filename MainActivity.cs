using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Quiz_App.Activities;
using Android.Views;

namespace Quiz_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        Android.Support.V7.Widget.Toolbar toolbar;
        Android.Support.V4.Widget.DrawerLayout drawerLayout;
        Android.Support.Design.Widget.NavigationView navigationView;

        LinearLayout historyLayout;
        LinearLayout spaceLayout;
        LinearLayout geographyLayout;
        LinearLayout engineeringLayout;
        LinearLayout programmingLayout;
        LinearLayout businessLayout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.toolbar);
            drawerLayout = (Android.Support.V4.Widget.DrawerLayout)FindViewById(Resource.Id.drawerLayout);
            navigationView = (Android.Support.Design.Widget.NavigationView)FindViewById(Resource.Id.navview);
            navigationView.NavigationItemSelected += NavigationView_NavigationItemSelected;

            //Setup Tooolbar
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Topics";
            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.menuaction);
            actionBar.SetDisplayHomeAsUpEnabled(true);

            // View Setups
            historyLayout = (LinearLayout)FindViewById(Resource.Id.historyLayout);
            spaceLayout = (LinearLayout)FindViewById(Resource.Id.spaceLayout);
            geographyLayout = (LinearLayout)FindViewById(Resource.Id.geograpyLayout);
            engineeringLayout = (LinearLayout)FindViewById(Resource.Id.engineeringLayout);
            programmingLayout = (LinearLayout)FindViewById(Resource.Id.programmingLayout);
            businessLayout = (LinearLayout)FindViewById(Resource.Id.businessLayout);

            // Click Event Handlers
            historyLayout.Click += HistoryLayout_Click;
            geographyLayout.Click += GeographyLayout_Click;
            spaceLayout.Click += SpaceLayout_Click;
            engineeringLayout.Click += EngineeringLayout_Click;
            programmingLayout.Click += ProgrammingLayout_Click;
            businessLayout.Click += BusinessLayout_Click;

        }

        private void NavigationView_NavigationItemSelected(object sender, Android.Support.Design.Widget.NavigationView.NavigationItemSelectedEventArgs e)
        {
           if(e.MenuItem.ItemId == Resource.Id.navHistory)
            {
                InitHistory();
                drawerLayout.CloseDrawers();
            }
           else if(e.MenuItem.ItemId == Resource.Id.navGeography)
            {
                InitGeography();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navSpace)
            {
                InitSpace();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navProgramming)
            {
                InitProgramming();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navEngineering)
            {
                InitEngineering();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navBusiness)
            {
                InitBusiness();
                drawerLayout.CloseDrawers();
            }
        }

        private void BusinessLayout_Click(object sender, System.EventArgs e)
        {
            InitBusiness();
        }

        private void ProgrammingLayout_Click(object sender, System.EventArgs e)
        {
            InitProgramming();
        }

        private void EngineeringLayout_Click(object sender, System.EventArgs e)
        {
            InitEngineering();
        }

        private void SpaceLayout_Click(object sender, System.EventArgs e)
        {
            InitSpace();
        }

        private void GeographyLayout_Click(object sender, System.EventArgs e)
        {
            InitGeography();
        }

        private void HistoryLayout_Click(object sender, System.EventArgs e)
        {
            InitHistory();
        }

        void InitHistory()
        {
            Intent intent = new Intent(this, typeof(QuizDescripTionActivity));
            intent.PutExtra("topic", "History");
            StartActivity(intent);
        }

        void InitGeography()
        {
            Intent intent = new Intent(this, typeof(QuizDescripTionActivity));
            intent.PutExtra("topic", "Geography");
            StartActivity(intent);
        }

        void InitSpace()
        {
            Intent intent = new Intent(this, typeof(QuizDescripTionActivity));
            intent.PutExtra("topic", "Space");
            StartActivity(intent);
        }

        void InitEngineering()
        {
            Intent intent = new Intent(this, typeof(QuizDescripTionActivity));
            intent.PutExtra("topic", "Engineering");
            StartActivity(intent);
        }

        void InitProgramming()
        {
            Intent intent = new Intent(this, typeof(QuizDescripTionActivity));
            intent.PutExtra("topic", "Programming");
            StartActivity(intent);
        }
        
        void InitBusiness()
        {
            Intent intent = new Intent(this, typeof(QuizDescripTionActivity));
            intent.PutExtra("topic", "Business");
            StartActivity(intent);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    drawerLayout.OpenDrawer((int)GravityFlags.Left);
                    return true;

                default:
                    return base.OnOptionsItemSelected(item);

            }

            
        }
    }
}