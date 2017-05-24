// LeadToolsRemoveView.cpp : implementation of the CLeadToolsRemoveView class
//

#include "stdafx.h"
#include "LeadToolsRemove.h"

#include "LeadToolsRemoveDoc.h"
#include "LeadToolsRemoveView.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CLeadToolsRemoveView

IMPLEMENT_DYNCREATE(CLeadToolsRemoveView, CView)

BEGIN_MESSAGE_MAP(CLeadToolsRemoveView, CView)
	//{{AFX_MSG_MAP(CLeadToolsRemoveView)
		// NOTE - the ClassWizard will add and remove mapping macros here.
		//    DO NOT EDIT what you see in these blocks of generated code!
	//}}AFX_MSG_MAP
	// Standard printing commands
	ON_COMMAND(ID_FILE_PRINT, CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, CView::OnFilePrintPreview)
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CLeadToolsRemoveView construction/destruction

CLeadToolsRemoveView::CLeadToolsRemoveView()
{
	// TODO: add construction code here

}

CLeadToolsRemoveView::~CLeadToolsRemoveView()
{
}

BOOL CLeadToolsRemoveView::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: Modify the Window class or styles here by modifying
	//  the CREATESTRUCT cs

	return CView::PreCreateWindow(cs);
}

/////////////////////////////////////////////////////////////////////////////
// CLeadToolsRemoveView drawing

void CLeadToolsRemoveView::OnDraw(CDC* pDC)
{
	CLeadToolsRemoveDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	// TODO: add draw code for native data here
}

/////////////////////////////////////////////////////////////////////////////
// CLeadToolsRemoveView printing

BOOL CLeadToolsRemoveView::OnPreparePrinting(CPrintInfo* pInfo)
{
	// default preparation
	return DoPreparePrinting(pInfo);
}

void CLeadToolsRemoveView::OnBeginPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add extra initialization before printing
}

void CLeadToolsRemoveView::OnEndPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add cleanup after printing
}

/////////////////////////////////////////////////////////////////////////////
// CLeadToolsRemoveView diagnostics

#ifdef _DEBUG
void CLeadToolsRemoveView::AssertValid() const
{
	CView::AssertValid();
}

void CLeadToolsRemoveView::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CLeadToolsRemoveDoc* CLeadToolsRemoveView::GetDocument() // non-debug version is inline
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CLeadToolsRemoveDoc)));
	return (CLeadToolsRemoveDoc*)m_pDocument;
}
#endif //_DEBUG

/////////////////////////////////////////////////////////////////////////////
// CLeadToolsRemoveView message handlers
