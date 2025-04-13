// minimalmsg.cpp//
#include <afxwin.h>

// 1.  Class to implement application UI.//
class CMyFrame : public CFrameWnd
{
public:
	CMyFrame();
protected:
	DECLARE_MESSAGE_MAP()
	void OnClose();
	void OnPaint();
};

CMyFrame::CMyFrame()
{	 
	Create(NULL, _T("Minimal MFC")); 
}

BEGIN_MESSAGE_MAP(CMyFrame, CFrameWnd)
	ON_WM_CLOSE()
	ON_WM_PAINT()
END_MESSAGE_MAP()

void CMyFrame::OnClose()
{
	UINT nResult = MessageBox("Exit from this application?", "Minimal MFC", MB_YESNO);
	if( nResult == IDYES)
	{
		PostQuitMessage(0);
	}
}

void CMyFrame::OnPaint()
{
	CPaintDC dc(this);
	CRect rcClient;
	GetClientRect(&rcClient);
	dc.DrawText(_T("Hello World!"), rcClient, DT_SINGLELINE | DT_CENTER | DT_VCENTER);
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
