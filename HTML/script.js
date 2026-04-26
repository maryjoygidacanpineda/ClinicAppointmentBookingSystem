const API_BASE = "https://localhost:7000/api";

// DOM Elements
const elements = {
    fullName: document.getElementById("fullName"),
    birthdate: document.getElementById("birthdate"),
    age: document.getElementById("age"),
    gender: document.getElementById("gender"),
    contactInfo: document.getElementById("contactInfo"),
    disease: document.getElementById("disease"),
    history: document.getElementById("history"),
    allergies: document.getElementById("allergies"),
    medications: document.getElementById("medications"),
    doctorSelect: document.getElementById("doctorSelect"),
    appointmentDateTime: document.getElementById("appointmentDateTime"),
    paymentMethod: document.getElementById("paymentMethod"),
    status: document.getElementById("status")
};
const doctorSelect = document.getElementById("doctorSelect");

function goToBooking() {
    document.getElementById("homePage").classList.add("hidden");
    document.getElementById("bookingPage").classList.remove("hidden");
    loadDoctors();
    document.body.scrollTop = 0;
}

function goHome() {
    document.getElementById("bookingPage").classList.add("hidden");
    document.getElementById("homePage").classList.remove("hidden");
}


// Load doctors when page opens or booking opens
async function loadDoctors() {
    try {
        const res = await fetch(`${API_BASE}/doctors`);
        const doctors = await res.json();

        // clear old options
        doctorSelect.innerHTML = `<option value="">Select Doctor</option>`;

        doctors.forEach(doc => {
            const option = document.createElement("option");

            option.value = doc.doctorId || doc.DoctorId;

            const name = doc.name || doc.Name;
            const spec = doc.specialization || doc.Specialization;

            option.textContent = `${name} - ${spec}`;

            doctorSelect.appendChild(option);
        });

    } catch (err) {
        console.error("Error loading doctors:", err);
        doctorSelect.innerHTML = `<option>Error loading doctors</option>`;
    }

}

// Auto-calculate Age
elements.birthdate.addEventListener("change", function() {
    if (this.value) {
        const birthDate = new Date(this.value);
        const today = new Date();
        let age = today.getFullYear() - birthDate.getFullYear();
        
        const monthDiff = today.getMonth() - birthDate.getMonth();
        if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < birthDate.getDate())) {
            age--;
        }
        
        elements.age.value = age;
    }
});

async function confirmBooking() {
    const btn = document.querySelector(".btn-primary");
    if (btn.disabled) return;

    if (!elements.fullName.value || !elements.contactInfo.value || !elements.doctorSelect.value) {
        alert("❌ Please fill required fields");
        return;
    }


    const appointmentData= {
        FullName: elements.fullName.value,
        ContactInfo: elements.contactInfo.value,
        DoctorId: parseInt(elements.doctorSelect.value),
        Birthdate: elements.birthdate.value,
        Age: elements.age.value || 0,
        Gender: elements.gender.value,
        Disease: elements.disease.value,
        History: elements.history.value,
        Allergies: elements.allergies.value,
        Medication: elements.medications.value,
        AppointmentDateTime: elements.appointmentDateTime.value,
        PaymentMethod: elements.paymentMethod.value,
        Status: elements.status.value
    };

    try {
         btn.textContent = "Booking...";
         btn.disabled = true;

        const res = await fetch(`${API_BASE}/appointments`, {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(appointmentData)
        });

        if (res.ok){
            alert("✅ Appointment booked successfully!\n\nConfirmation sent to your contact.");
            clearForm();
            goHome();
        } else {
           const err = await res.text();
            console.error(err);
            alert("❌ Failed to book appointment");
        }
    } catch (error) {
        console.error(error);
        alert("❌ Server error. Please try again.");
    } finally {
        btn.textContent = "Confirm Booking";
        btn.disabled = false;
    }
}
function clearForm() {
    Object.values(elements).forEach(el => {
        if (el && el.tagName !== "SELECT") {
            el.value = "";
        }
    });

    elements.paymentMethod.value = "Cash";
    elements.status.value = "Scheduled";
}

// INIT
window.onload = loadDoctors;

document.addEventListener("DOMContentLoaded", () => {
    const today = new Date().toISOString().split("T")[0];
    elements.appointmentDateTime.min = today;
});
