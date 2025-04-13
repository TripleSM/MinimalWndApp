// minimalmfc.cpp//
#include <afxwin.h>

// 1.  Class to implement application UI.//
class CMyFrame : public CFrameWnd
{
public:
	CMyFrame();
};

CMyFrame::CMyFrame()
{	 
	 Create(NULL, _T("Minimal MFC")); 
}

// 2. Class to create and show application UI.//
class CMyApp : public CWinApp
{
	BOOL InitInstance();
};

BOOL CMyApp::InitInstance()
{
	 m_pMainWnd = new CMyFrame();;
	 m_pMainWnd->ShowWindow(SW_SHOW);
	 m_pMainWnd->UpdateWindow();
	 return TRUE;
}

// 3. The application object.//
CMyApp theApp; 
