package vn.aftech.logic;

import java.util.ArrayList;
import java.util.List;

import vn.aftech.form.LoginForm;

public class LoginLogic {
	
	private List<String> users;
	
	public LoginLogic() {
		bindingData();
	}
	
	public boolean isLoginSuccess(LoginForm loginForm) {
		for (String username : users) {
			if (loginForm.getUsername().equalsIgnoreCase(username)) {
				return true;
			}
		}
		return false;
	}
	
	private void bindingData() {
		users = new ArrayList<String>();
		users.add("TrinhVanQui");
		users.add("RuaNongLam");
		users.add("kedoki");
	}

}
