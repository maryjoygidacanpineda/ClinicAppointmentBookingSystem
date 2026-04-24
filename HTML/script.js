const API = "https://localhost:7000/api";

// Get all elements
const fullName = document.getElementById("fullName");
const birthdate = document.getElementById("birthdate");
const age = document.getElementById("age");
const gender = document.getElementById("gender");
const contactInfo = document.getElementById("contactInfo");
const disease = document.getElementById("disease");
const bloodType = document.getElementById("bloodType");
const allergies = document.getElementById("allergies");
const medications = document.getElementById("medications");
const history = document.getElementById("history");
const appointmentDateTime = document.getElementById("appointmentDateTime");
const paymentMethod = document.getElementById("paymentMethod");

// NAVIGATION
function goToBooking(){
    document.getElementById("homePage").classList.add("hidden");
    document.getElementById("bookingPage").classList.remove("hidden");
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}

function goHome(){
    document.getElementById("bookingPage").classList.add("hidden");
    document.getElementById("homePage").classList.remove("hidden");
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}

// AUTO CALCULATE AGE
birthdate.addEventListener("change", function(){
    if (this.value) {
        let birth = new Date(this.value);
        let today = new Date();
        let ageValue = today.getFullYear() - birth.getFullYear();
        
        let monthDiff = today.getMonth() - birth.getMonth();
        if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < birth.getDate())) {
            ageValue--;
        }
        
        age.value = ageValue;
    }
});

// CONFIRM BOOKING
async function confirmBooking(){
    // Validation
    if (!fullName.value || !appointmentDateTime.value) {
        alert("Please fill required fields!");
        return;
    }

    const data = {
        fullName: fullName.value,
        birthdate: birthdate.value,
        age: age.value || 0,
        gender: gender.value,
        contact: contactInfo.value,
        disease: disease.value,
        bloodType: bloodType.value,
        allergies: allergies.value,
        medications: medications.value,
        history: history.value,
        dateTime: appointmentDateTime.value,
        service: "General Consultation",
        doctor: "General Practitioner",
        payment: paymentMethod.value,
        status: "Scheduled"
    };

    try {
        // Show loading
        const submitBtn = event.target;
        submitBtn.textContent = "Saving...";
        submitBtn.disabled = true;

        const res = await fetch(API + "/appointments", {
    method: "POST",
    headers: {"Content-Type": "application/json"},
    body: JSON.stringify(data)
    });

        const result = await res.json();
        
        alert("✅ Appointment booked successfully!");
        goHome();
        clearForm();

    } catch(err) {
        console.error(err);
        alert("❌ Error connecting to server. Please try again.");
    } finally {
        // Reset button
        const submitBtn = document.querySelector('.primary-btn');
        submitBtn.textContent = "Confirm Booking";
        submitBtn.disabled = false;
    }
}

function clearForm() {
    fullName.value = '';
    birthdate.value = '';
    age.value = '';
    contactInfo.value = '';
    disease.value = '';
    bloodType.value = '';
    allergies.value = '';
    medications.value = '';
    history.value = '';
    appointmentDateTime.value = '';
    paymentMethod.value = 'Cash';
}

// Initialize
document.addEventListener('DOMContentLoaded', function() {
    // Set min date to today
    const today = new Date().toISOString().split('T')[0];
    appointmentDateTime.min = today;
});