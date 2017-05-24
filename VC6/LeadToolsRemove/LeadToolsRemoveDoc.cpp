// LeadToolsRemoveDoc.cpp : implementation of the CLeadToolsRemoveDoc class
//

#include "stdafx.h"
#include "LeadToolsRemove.h"

#include "LeadToolsRemoveDoc.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CLeadToolsRemoveDoc

IMPLEMENT_DYNCREATE(CLeadToolsRemoveDoc, CDocument)

BEGIN_MESSAGE_MAP(CLeadToolsRemoveDoc, CDocument)
	//{{AFX_MSG_MAP(CLeadToolsRemoveDoc)
		// NOTE - the ClassWizard will add and remove mapping macros here.
		//    DO NOT EDIT what you see in these blocks of generated code!
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CLeadToolsRemoveDoc construction/destruction

CLeadToolsRemoveDoc::CLeadToolsRemoveDoc()
{
	// TODO: add one-time construction code here

}

CLeadToolsRemoveDoc::~CLeadToolsRemoveDoc()
{
}

BOOL CLeadToolsRemoveDoc::OnNewDocument()
{
	if (!CDocument::OnNewDocument())
		return FALSE;

	// TODO: add reinitialization code here
	// (SDI documents will reuse this document)

	return TRUE;
}



/////////////////////////////////////////////////////////////////////////////
// CLeadToolsRemoveDoc serialization

void CLeadToolsRemoveDoc::Serialize(CArchive& ar)
{
	if (ar.IsStoring())
	{
		// TODO: add storing code here
	}
	else
	{
		// TODO: add loading code here
	}
}

/////////////////////////////////////////////////////////////////////////////
// CLeadToolsRemoveDoc diagnostics

#ifdef _DEBUG
void CLeadToolsRemoveDoc::AssertValid() const
{
	CDocument::AssertValid();
}

void CLeadToolsRemoveDoc::Dump(CDumpContext& dc) const
{
	CDocument::Dump(dc);
}
#endif //_DEBUG

/////////////////////////////////////////////////////////////////////////////
// CLeadToolsRemoveDoc commands
