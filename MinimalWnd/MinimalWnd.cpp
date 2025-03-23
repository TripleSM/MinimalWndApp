// minimalwnd.cpp//

#include <windows.h>

//#pragma comment(lib, "user32.lib")

int WINAPI WinMain(HINSTANCE hThisInstance, HINSTANCE hPrevInstance, 
LPSTR lpCmdLine, int nCmdShow)
{
	MessageBox(NULL, "Hello World!", "Minimal Window", MB_OK);
	return 0;
}

