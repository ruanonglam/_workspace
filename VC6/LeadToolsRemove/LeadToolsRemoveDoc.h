// LeadToolsRemoveDoc.h : interface of the CLeadToolsRemoveDoc class
//
/////////////////////////////////////////////////////////////////////////////

#if !defined(AFX_LEADTOOLSREMOVEDOC_H__0A1D117B_8B17_469F_8D4F_CC97228A1E8A__INCLUDED_)
#define AFX_LEADTOOLSREMOVEDOC_H__0A1D117B_8B17_469F_8D4F_CC97228A1E8A__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000


class CLeadToolsRemoveDoc : public CDocument
{
protected: // create from serialization only
	CLeadToolsRemoveDoc();
	DECLARE_DYNCREATE(CLeadToolsRemoveDoc)

// Attributes
public:

// Operations
public:

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CLeadToolsRemoveDoc)
	public:
	virtual BOOL OnNewDocument();
	virtual void Serialize(CArchive& ar);
	//}}AFX_VIRTUAL

// Implementation
public:
	virtual ~CLeadToolsRemoveDoc();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Generated message map functions
protected:
	//{{AFX_MSG(CLeadToolsRemoveDoc)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_LEADTOOLSREMOVEDOC_H__0A1D117B_8B17_469F_8D4F_CC97228A1E8A__INCLUDED_)
