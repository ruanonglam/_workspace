package vn.aftech.action;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.struts.action.Action;
import org.apache.struts.action.ActionForm;
import org.apache.struts.action.ActionForward;
import org.apache.struts.action.ActionMapping;

import vn.aftech.common.Common;

public class ChooseAction extends Action {
	
	@Override
	public ActionForward execute(ActionMapping mapping, ActionForm form,
			HttpServletRequest request, HttpServletResponse response)
			throws Exception {
		
		if (getErrors(request) != null && getErrors(request).size() > 0) {
			return mapping.getInputForward();
		}

		return mapping.findForward(Common.SUCCESS);
	}

}