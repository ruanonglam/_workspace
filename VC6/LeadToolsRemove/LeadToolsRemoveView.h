// LeadToolsRemoveView.h : interface of the CLeadToolsRemoveView class
//
/////////////////////////////////////////////////////////////////////////////

#if !defined(AFX_LEADTOOLSREMOVEVIEW_H__E4C0E58E_E87B_427E_BAEF_743FC8B92336__INCLUDED_)
#define AFX_LEADTOOLSREMOVEVIEW_H__E4C0E58E_E87B_427E_BAEF_743FC8B92336__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000


class CLeadToolsRemoveView : public CView
{
protected: // create from serialization only
	CLeadToolsRemoveView();
	DECLARE_DYNCREATE(CLeadToolsRemoveView)

// Attributes
public:
	CLeadToolsRemoveDoc* GetDocument();

// Operations
public:

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CLeadToolsRemoveView)
	public:
	virtual void OnDraw(CDC* pDC);  // overridden to draw this view
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
	protected:
	virtual BOOL OnPreparePrinting(CPrintInfo* pInfo);
	virtual void OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo);
	virtual void OnEndPrinting(CDC* pDC, CPrintInfo* pInfo);
	//}}AFX_VIRTUAL

// Implementation
public:
	virtual ~CLeadToolsRemoveView();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Generated message map functions
protected:
	//{{AFX_MSG(CLeadToolsRemoveView)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // debug version in LeadToolsRemoveView.cpp
inline CLeadToolsRemoveDoc* CLeadToolsRemoveView::GetDocument()
   { return (CLeadToolsRemoveDoc*)m_pDocument; }
#endif

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_LEADTOOLSREMOVEVIEW_H__E4C0E58E_E87B_427E_BAEF_743FC8B92336__INCLUDED_)
