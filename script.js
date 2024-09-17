const sidebar = document.querySelector(".sidebar");
function showSidebar() {
  sidebar.style.display = "flex";
}

const closeMenu = document.getElementById("close-menu");

closeMenu.addEventListener("click", (e) => {
  sidebar.style.display = "none";
});

const navlinks = document.querySelectorAll(".nav-link");
navlinks.forEach((link) => {
  link.addEventListener("click", (e) => {
    navlinks.forEach((l) => l.classList.remove("active"));
    e.target.classList.add("active");
  });
});
