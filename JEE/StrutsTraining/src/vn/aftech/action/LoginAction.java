package vn.aftech.action;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.struts.action.Action;
import org.apache.struts.action.ActionForm;
import org.apache.struts.action.ActionForward;
import org.apache.struts.action.ActionMapping;

import vn.aftech.common.Common;
import vn.aftech.form.LoginForm;
import vn.aftech.logic.LoginLogic;

public class LoginAction extends Action {
	
	LoginLogic logic;
	LoginForm loginForm;

	@Override
	public ActionForward execute(ActionMapping mapping, ActionForm form,
			HttpServletRequest request, HttpServletResponse response)
			throws Exception {
		if (getErrors(request) == null || getErrors(request).size() == 0) {
			logic = new LoginLogic();
			loginForm = (LoginForm) form;
			
			if (!logic.isLoginSuccess(loginForm)) {
				return mapping.findForward(Common.FAILED);
			}
			return mapping.findForward(Common.SUCCESS);
		} else {
			return mapping.getInputForward();
		}
		
	}
	
}
