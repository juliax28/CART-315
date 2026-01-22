/// @description Insert description here
// You can write your code in this editor
ysp += 0.1
xsp= 0
if keyboard_check(vk_left){
	xsp=-1
	sprite_index = sPlayerL
}

if keyboard_check(vk_right){
	xsp=+1
	sprite_index = sPlayerR
}
if place_meeting(x,y+1,oSolid){
	ysp=0
	if keyboard_check(vk_up){
		ysp=-2
	}
}
move_and_collide(xsp,ysp,oSolid)

// spike + flag collisions

if place_meeting(x,y,oGem){

room_goto_next()
}


if place_meeting(x,y,oSpike) or y >= room_height{

room_restart()
}


// animation
//sprite_index = sPlayerR

if (xsp==0 && keyboard_check_released(vk_left)){
	sprite_index = sPlayerIdleL
}
if (xsp==0 && keyboard_check_released(vk_right)){
	sprite_index = sPlayerIdleR
}

