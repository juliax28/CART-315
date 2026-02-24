/// @description Initialize chatterbox and set variables
///https://www.youtube.com/watch?v=r_hqY-7rT0c

ChatterboxLoadFromFile("yarn01.yarn");
ChatterboxAddFunction("bg", background_set_index);
chatterbox = ChatterboxCreate();
ChatterboxJump(chatterbox, "Start");
chatterbox_update();

option_index = 0;

size = [0.7, 0.75];
colour = [c_ltgray, c_white];

