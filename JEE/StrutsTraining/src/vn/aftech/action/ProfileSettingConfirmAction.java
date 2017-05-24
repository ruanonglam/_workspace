package vn.aftech.action;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.struts.action.Action;
import org.apache.struts.action.ActionForm;
import org.apache.struts.action.ActionForward;
import org.apache.struts.action.ActionMapping;

import vn.aftech.common.Common;
import vn.aftech.util.Validate;

public class ProfileSettingConfirmAction extends Action {
	
	private static final String SUBMIT_ACTION = "submit";
	private static final String EDIT_ACTION = "edit";

	@Override
	public ActionForward execute(ActionMapping mapping, ActionForm form,
			HttpServletRequest request, HttpServletResponse response)
			throws Exception {
		String action = getAction(request);
		
		if (!EDIT_ACTION.equals(action) && !SUBMIT_ACTION.equals(action)) {
			return mapping.findForward(Common.FAILED); // TODO
		}
		
		if (EDIT_ACTION.equals(action)) {
			return mapping.findForward(EDIT_ACTION);
		}
		
		// Some code
		
		return mapping.findForward(SUBMIT_ACTION);
	}
	
	private String getAction(HttpServletRequest request) {
		String submit = request.getParameter("Submit");
		String edit = request.getParameter("Edit");
		
		if (!Validate.isNullOrEmptyWithoutSpace(submit)) {
			return SUBMIT_ACTION;
		} else if (!Validate.isNullOrEmptyWithoutSpace(edit)) {
			return EDIT_ACTION;
		} else {
			return Common.FAILED;
		}
	}
	
}
