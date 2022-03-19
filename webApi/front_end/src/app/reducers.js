import navigationReducer from "./../features/navigation/navigationSlice";
import footerReducer from "./../features/footer/footerSlice";
import usersReducer from "./../features/components/form/usersSlice";
import industriesReducer from "./../features/components/industry/industriesSlice";
import careersReducer from "./../features/components/career/careersSlice";
import servicesReducer from "./../features/components/services/servicesSlice";
import aboutReducer from "./../features/components/about/aboutSlice";
import testimonialsReducer from "./../features/components/testimonials/testimonialsSlice";
import articlesReducer from "./../features/components/articles/articlesSlice";
import emailsReducer from "./../features/components/form/emailsSlice";
import adminsReducer from "./../features/components/admin/adminsReducer";
import commentersReducer from "./../features/components/admin/commentersReducer";
import adminsReducer from "./../features/components/admin/adminsReducer";
import customersReducer from "./../features/components/admin/customersReducer";
import ordersReducer from "./../features/components/admin/ordersReducer";

const rootReducer = {
  navigation: navigationReducer,
  footer: footerReducer,
  users: usersReducer,
  industries: industriesReducer,
  careers: careersReducer,
  services: servicesReducer,
  about: aboutReducer,
  testimonials: testimonialsReducer,
  articles: articlesReducer,
  emails: emailsReducer,
  orders: ordersReducer,
  commenters: commentersReducer,
  admins: adminsReducer,
  customers: customersReducer,
};

export default rootReducer;
