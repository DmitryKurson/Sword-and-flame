namespace Sword_and_flame
{
    public partial class EventEnd : Form
    {
        public EventEnd()
        {
            InitializeComponent();
        }

        private void EventEnd_Load(object sender, EventArgs e)
        {
            LevelProperties.journey_map_current_level_position = LevelProperties.journey_map_go_TO; // ЭТО НАДО ВСТАВИТЬ ПОСЛЕ ПОБЕДЫ В ИГРОВОМ УРОВНЕ
        }

        private void EventEnd_openJM_btn_Click(object sender, EventArgs e)
        {
            JourneyMap journeymap_obj = new JourneyMap();
            journeymap_obj.ShowDialog();
        }
    }
}
