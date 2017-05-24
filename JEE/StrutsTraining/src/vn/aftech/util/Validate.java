package vn.aftech.util;

public class Validate {

	/**
	 * Kiểm tra chuỗi giá trị <i>value</i> được truyền vào có <b>null</b> hoặc
	 * <b>empty</b> hay không?
	 * 
	 * @param value
	 *            Chuỗi giá trị cần kiểm tra.
	 * @return Trường hợp chuỗi giá trị <i>value</i> là <b>null</b> hoặc
	 *         <b>empty</b> thì sẽ return <b>true</b>.
	 *         <p>
	 *         Ngược lại thì return <b>false</b>.
	 */
	public static boolean isNullOrEmpty(String value) {
		if (value == null || value.equals("")) {
			return true;
		}
		return false;
	}

	/**
	 * Kiểm tra chuỗi giá trị <i>value</i> được truyền vào có <b>null</b>,
	 * <b>empty</b> hoặc <b>chuỗi rỗng(có nhiều space)</b> hay không?
	 * 
	 * @param value
	 *            Chuỗi giá trị cần kiểm tra.
	 * @return Trường hợp chuỗi giá trị <i>value</i> là <b>null</b> hoặc
	 *         <b>empty</b> thì sẽ return <b>true</b>.
	 *         <p>
	 *         Ngược lại thì return <b>false</b>.
	 */
	public static boolean isNullOrEmptyWithoutSpace(String value) {
		if (value == null || value.trim().equals("")) {
			return true;
		}
		return false;
	}

	/**
	 * Kiểm tra độ dài ký tự của chuỗi giá trị <i>value</i> được truyền vào có
	 * lớn hơn giá trị <i>maxlength</i> hay không?
	 * 
	 * @param value
	 *            Chuỗi giá trị cần kiểm tra độ dài ký tự.
	 * @param maxlength
	 *            Giá trị maxlength được dùng để so sánh với length của chuỗi
	 *            giá trị <i>value</i>
	 * @return Trường hợp độ dài của chuỗi giá trị <i>value</i> lớn hơn giá trị
	 *         của <i>maxlength</i> thì sẽ return <b>true</b>
	 *         <p>
	 *         Ngược lại thì return <b>false</b>
	 */
	public static boolean isOverMaxlength(String value, int maxlength) {
		if (value != null && value.length() > maxlength) {
			return true;
		}
		return false;
	}
	
	public static void main(String[] args) {
		System.out.println(isOverMaxlength("12346",  5));
	}

}
